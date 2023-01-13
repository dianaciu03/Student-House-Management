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
        
        public bool IsPaymentComplete(Payment payment)
        {
            if (payment.TenantsNotPaidCount() == 0)
            {
                payments.Remove(payment);
                return true;
            }
            else
                return false;
        }

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

        public PaymentManager? LoadRecruiter(string fileName)
        {
            FileStream? stream = null;

            try
            {
                stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                XmlReader reader
                    = XmlDictionaryReader.CreateTextReader(stream,
                                                new XmlDictionaryReaderQuotas());

                Type mainType = typeof(PaymentManager);
                List<Type> auxiliaryTypes
                    = new List<Type> { typeof(Payment) };
                DataContractSerializer serializer
                    = new DataContractSerializer(mainType, auxiliaryTypes);


                return (PaymentManager?)serializer.ReadObject(reader);

            }
            catch (FileNotFoundException)
            {
                return new PaymentManager();
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }

        public void SaveRecruiter(PaymentManager paymentManager , string fileName)
        {
            FileStream? stream = null;

            try
            {
                stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);

                Type mainType = typeof(PaymentManager);
                List<Type> auxiliaryTypes
                    = new List<Type> { typeof(Payment) };
                DataContractSerializer serializer
                    = new DataContractSerializer(mainType, auxiliaryTypes);

                serializer.WriteObject(stream, paymentManager);
                stream.Flush();
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }
    }
}

