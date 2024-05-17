using static System.Net.Mime.MediaTypeNames;

namespace Practica2TN.Entities.Ej2
{
    public class PhotoBook
    {

        protected int numPages;
        public int id { get; set; }

        public PhotoBook()
        {
            numPages = 16;
        }

        public PhotoBook(int pages)
        {
            numPages = pages;
        }

        public int GetNumberPages()
        {
            return numPages;
        }



    }
}
