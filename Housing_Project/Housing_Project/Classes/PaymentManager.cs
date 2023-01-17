using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using Microsoft.VisualBasic.ApplicationServices;
using System.Runtime.CompilerServices;
using System.Xml;

namespace Housing_Project.Classes
{
    [DataContract]
    public class PaymentManager
    {
        [DataMember] private List<Payment> payments = new List<Payment>();
        private const string filePath = @"..\..\..\..\Data\paymentData.txt";
        
        public double CalculatePricePerPerson(Payment payment, int numberTenants)
        {
            return (double)payment.TotalPrice / numberTenants;
        }

        public void AddPaymentToList(Payment payment)
        {
            payments.Add(payment);
        }

        public Payment[] GetPayments()
        {
            return payments.ToArray();
        }

        public Payment GetPayment(int index)
        {
            return payments[index];
        }

        public PaymentManager LoadPaymentManagerData()
        {
            try
            {
                PaymentManager paymentManager = new PaymentManager();

                using (FileStream fs = new(filePath, FileMode.Open, FileAccess.Read))
                {
                    Type typeToSerialize = typeof(PaymentManager);

                    List<Type> auxiliaryTypes = new List<Type>()
                    {
                        typeof(Payment),
                        typeof(Tenant)
                    };

                    DataContractSerializer dcs = new(typeToSerialize, auxiliaryTypes);
                    XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());
                    paymentManager = (PaymentManager)dcs.ReadObject(reader, true);

                    return paymentManager;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void WritePaymentManagerData(PaymentManager data)
        {
            try
            {
                using (FileStream ClearFile = new(filePath, FileMode.Truncate, FileAccess.Write)) ;
                using (FileStream fs = new(filePath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    Type typeToSerialize = typeof(PaymentManager);

                    List<Type> auxiliaryTypes = new List<Type>()
                    {
                        typeof(Payment),
                        typeof(Tenant)
                    };

                    DataContractSerializer dcs = new(typeToSerialize);
                    dcs.WriteObject(fs, data);
                }
            }
            catch (Exception) { }
        }
    }
}

