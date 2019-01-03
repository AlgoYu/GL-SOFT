using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Web;
using CompanyWebSite.Areas.ManagementSystem.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanyWebSite.Areas.ManagementSystem.Controllers
{
    public class FileUploadController : ManagementSystemControllerBase
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public FileUploadController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        /// <summary>
        /// 上传并中心裁剪图片
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        [HttpPost]
        public JsonResult MiddleCuttingImage(IFormFile file)
        {
            /*            if (files==null || files.Count <= 0)
                        {
                            return Json(new TableResponse()
                            {
                                Message = "没有检查到文件"
                            });
                        }*/
            if (file==null)
            {
                return Json(new TableResponse()
                {
                    Message = "没有检查到文件"
                });
            }

            //var file = files[0];
            var extName = Path.GetExtension(file.FileName);
            var imgExts = new[] { ".jpg", ".bmp", ".png", ".gif" };

            if (imgExts.All(ext => ext != extName))
            {
                return Json(new TableResponse()
                {
                    Message = "文件格式不正确"
                });
            }

            var saveDirectory = "/upload//images/" + DateTime.Now.ToString("yyyyMMdd") + "/";
            var fileName = DateTime.Now.ToString("yyyyMMddHHmmsssfff") + extName;
            var absSavePath = _hostingEnvironment.WebRootPath + saveDirectory;
            var fullFileName = absSavePath + fileName;

            if (!Directory.Exists(absSavePath))
            {
                Directory.CreateDirectory(absSavePath);
            }

            using (FileStream fileStream = System.IO.File.Create(fullFileName))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }

            return Json(new TableResponse()
            {
                Data = saveDirectory + fileName,
                Total = 1
            });
        }
    }
}