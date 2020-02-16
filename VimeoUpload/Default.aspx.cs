using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VimeoUpload
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void upload_btn_Click(object sender, EventArgs e)
        {
            string fullPath = string.Empty;
            try
            {
                 uploadVideo();
            }
            catch (Exception ex)
            {
                string message = string.Empty;
                while (ex != null)
                {
                    if (message == string.Empty)
                    {
                        message = ex.Message;
                    }
                    else
                    {
                        message = message + Environment.NewLine + ex.Message;
                    }
                    ex = ex.InnerException;
                }
                Response.Write(message);
            }
        }

        public async Task<string> uploadVideo()
        {
            var clientId = "710f6c309030976b81f10290fc8a215815c2b74e";
            var clientSecret = "8WIQG5etmifzzmaMgDxFiOPOklFEBxTFePtztNGkyaBYJZsvduKHHL+0Id/o9mcQEweBPFvmcq4jsR4GbEAl7TM91Q7gBjcE+gdYO2+Fcd+9VRTTACQZ4g4RIxK+d+GH";
            var redirectionUrl = "https://your_website_here.com/wherever-you-send-users-after-grant";
          
            var client = new VimeoDotNet.VimeoClient(clientId, clientSecret);
          
            fuVideoFile.SaveAs(@"D:\temp\" + fuVideoFile.FileName);
            VimeoDotNet.Net.BinaryContent _binaryContent=new VimeoDotNet.Net.BinaryContent(@"D:\temp\" + fuVideoFile.FileName);
            _binaryContent.ContentType = fuVideoFile.PostedFile.ContentType;
            _binaryContent.OriginalFileName = fuVideoFile.PostedFile.FileName;
            var url = await client.UploadEntireFileAsync(_binaryContent);
            Console.WriteLine(url);
            Console.WriteLine("Give me your access code...");
            var accessCode = Console.ReadLine();
            var token = await client.GetAccessTokenAsync(accessCode, redirectionUrl);
            
            return "";
        }
    }
}