using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ImageFilesManager : IImageFilesService
    {
        IImageFilesDal _ImageFilesDal;

        public ImageFilesManager(IImageFilesDal ımageFilesDal)
        {
            _ImageFilesDal = ımageFilesDal;
        }

        public List<ImageFiles> GetList()
        {
            return _ImageFilesDal.List();
        }
    }
}
