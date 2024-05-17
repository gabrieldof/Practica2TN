using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Practica2TN.Entities.Ej2;

namespace Practica2TN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ej2Controller : Controller
    {
        static List<PhotoBook> photoBooks = new List<PhotoBook>();

        [HttpPost("[action]")]
        public ActionResult<string> StandardAlbum([FromBody] int pages)
        {
            var photoBook = new PhotoBook(pages);
            photoBook.id = photoBooks.Count + 1;
            photoBooks.Add(photoBook);
            return Ok($"se creo el album {photoBook.id} estandar con {pages} paginas");

        }

        [HttpPost("[action]")]
        public ActionResult<string> BigAlbum()
        {
            var bigPhotoBook = new BigPhotoBook();

            bigPhotoBook.id = photoBooks.Count + 1;
            photoBooks.Add(bigPhotoBook);
            return Ok($"se creo el album {bigPhotoBook.id} grande con 64 paginas");

        }

        [HttpGet("[action]/{id}")]
        public ActionResult<int> GetNumberOfPages([FromRoute] int id)
        {
            PhotoBook? album = photoBooks.Find(p => p.id == id);

            if (album != null)
            {
                return Ok(album.GetNumberPages());
            }
            else
            {
                return NotFound($"no se encontro un album con el id {id}");
            }
        }
        [HttpGet("[action]")]
        public ActionResult<List<PhotoBook>> getAllBooks()
        {
            return photoBooks;
        }



    }
}
