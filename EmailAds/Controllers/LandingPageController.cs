using LP.Services.Poco;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmailAds.Controllers
{
    public class LandingPageController : Controller
    {
        private string physicalPath = @"~/UploadedLogos/";
        // GET: LandingPage
        public void Add(LandingPage Lp)
        {

            if (Request.Files.Count != 3)
            {
                throw new Exception("Please upoad all files!");
            }

            List<string> FileNames = UploadFile(Request.Files);

           

        }

        private List<string> UploadFile(HttpFileCollectionBase files)
        {

            //logic to write bytes in UploadedLogo folder
            //keep file name as GUID.jpg
            //return saved file path i.e Guid
            // and optionally write the file to disk
            List<string> UploadedFiles = new List<string>();
            foreach (string file in files)
            {
                string FileName = Guid.NewGuid().ToString();
                var fileContent = Request.Files[file];
                if (fileContent != null && fileContent.ContentLength > 0)
                {
                    // get a stream
                    var stream = fileContent.InputStream;
                 
                    var path = Path.Combine(Server.MapPath("~/App_Data/Images"), FileName + ".jpg");
                    using (var fileStream = System.IO.File.Create(path))
                    {
                        stream.CopyTo(fileStream);
                    }
                }
                UploadedFiles.Add(FileName);
            }

            return UploadedFiles;
        }
    }
}