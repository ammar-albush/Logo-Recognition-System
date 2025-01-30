using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogoRecognitionSystem
{
    [Serializable]
    public class TrainingSet
    {
        public string ImageName { get; set; }
        public int Match { get; set; }

        public Bitmap Image { get; set; }

        public bool isLogo { get; set; }

        public TrainingSet(string ImgName, int match, Bitmap image, bool islogo)
        {

            this.ImageName = ImgName;

            this.Match = match;

            this.Image = image;

            this.isLogo = islogo;

        }

    }

}
