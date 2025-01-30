using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogoRecognitionSystem
{
    public class BLob
    {

        public Bitmap Image { get; set; }

        public Rectangle Location { get; set; }

        public BLob(Bitmap bitmap,Rectangle rectangle)
        {
            this.Image = bitmap;
            this.Location = rectangle;

        }

    }
}
