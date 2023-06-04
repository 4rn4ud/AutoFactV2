using AutoFact2.Repository;
using AutoFact2.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace AutoFact2.Models
{
    public class Invoice
    {
        private int _id;
        private int _idCustomer;
        private DateTime _DateInvoice;
        private List<Invoiceline> _Invoiceline;
        private InvoiceRepository myrepofact;
        private InvoiceLineRepository myrepofactligne;

        public Invoice(int id, int idCustomer, DateTime DateInvoice)
        {
            this._id = id;
            this._idCustomer = idCustomer;
            this._DateInvoice = DateInvoice;
            this._Invoiceline = new List<Invoiceline>();
            InvoiceRepository myrepofact = new InvoiceRepository();
            InvoiceLineRepository myrepofactligne = new InvoiceLineRepository();
        }

        public Invoice()
        {

            InvoiceRepository myrepofact = new InvoiceRepository();
            InvoiceLineRepository myrepofactligne = new InvoiceLineRepository();
        }

        public void Create()
        {
           InvoiceRepository myrepofact = new InvoiceRepository();
           int idFacture = myrepofact.create(this._idCustomer, this._DateInvoice);
           this._id = idFacture;

        }
        public Invoice(int id)
        {
            this._id = id;
            InvoiceRepository myrepofact = new InvoiceRepository();
            InvoiceLineRepository myrepofactligne = new InvoiceLineRepository();
            this._DateInvoice = myrepofact.GetDate(id);
            this._idCustomer = myrepofact.GetIdCustomer(id);
            this._Invoiceline = myrepofactligne.FindAll(id);
        }

        public int GetId()
        {
            return _id;
        }

        public void SetId(int value)
        {
            this._id = value;
        }

        public int GetidCustomer()
        {
            return _idCustomer;
        }

        public void SetIdCustomer(int value)
        {
            this._idCustomer = value;
        }

        public DateTime GetDateInvoice()
        {
            return _DateInvoice.Date;
        }

        public void SetDateInvoice(DateTime value)
        {
            this._DateInvoice = value;
        }

        public List<Invoiceline> GetInvoiceline()
        {
            return _Invoiceline;
        }

        public decimal GetTotal()
        {
            decimal Total = 0;
            foreach (Invoiceline line in _Invoiceline)
            {
                Total = Total + line.GetAmount();
            }
            return Total;
        }

        public void GenerateInvoicePDF()
        {
            // Créer un nouveau document PDF
            Document document = new Document();

            // Définir le chemin de sortie du fichier PDF
            string filePath = "C:/Users/Titouan/Downloads/facture.pdf";

            // Créer un écrivain PDF pour écrire dans le document
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

            // Ouvrir le document pour écrire
            document.Open();
            string invoiceNumber = Convert.ToString(_id);
            string customerName = Convert.ToString( _idCustomer );
            string totalAmount = Convert.ToString( GetTotal()  );

            // Ajouter le contenu de la facture au document
            Paragraph header = new Paragraph("Facture #" + invoiceNumber, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.BOLD));
            Paragraph customer = new Paragraph("Client: " + customerName, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12));
            Paragraph amount = new Paragraph("Montant total: " + totalAmount, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12));

            // Ajouter les éléments au document
            document.Add(header);
            document.Add(customer);
            document.Add(amount);

            // Fermer le document
            document.Close();

            // Ouvrir le fichier PDF généré
            System.Diagnostics.Process.Start(filePath);
        }
    }
}