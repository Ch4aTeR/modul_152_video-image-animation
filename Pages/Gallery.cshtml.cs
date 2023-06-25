using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.IO;


namespace project.Pages
{
    public class GalleryModel : PageModel
    {
        public List<string>? ImagePaths { get; private set; }
        public List<string>? ImagePathsNew { get; private set; }

        public void OnGet()
        {
            var imageFolder = Path.Join("wwwroot", "images");
            ImagePaths = new List<string>(Directory.GetFiles(imageFolder));
            for (int i = 0; i < ImagePaths.Count; i++)
            {
                string originalPath = ImagePaths[i];
                string modifiedPath = originalPath.Replace("\\", "/");
                modifiedPath = modifiedPath.Replace("wwwroot", "");

                ImagePaths[i] = modifiedPath;
            }
        }
    }
}
