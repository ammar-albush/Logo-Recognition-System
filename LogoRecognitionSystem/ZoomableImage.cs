using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogoRecognitionSystem
{
	public partial class ZoomableImage : UserControl
	{
		public ZoomableImage()
		{
			InitializeComponent();

		}

		public new event MouseEventHandler Mouse_Up
		{
			add
			{
				this.ImagePB.MouseUp += value;
				
			}
			remove
			{
				this.ImagePB.MouseUp-= value;
				
			}
		}
		public new event MouseEventHandler Mouse_Move
		{
			add
			{
				this.ImagePB.MouseMove += value;

			}
			remove
			{
				this.ImagePB.MouseMove -= value;

			}
		}
		public new event MouseEventHandler Mouse_Down
		{
			add
			{
				this.ImagePB.MouseDown += value;

			}
			remove
			{
				this.ImagePB.MouseDown -= value;

			}
		}
		public new event PaintEventHandler PaintPB
		{
			add
			{
				this.ImagePB.Paint += value;

			}
			remove
			{
				this.ImagePB.Paint -= value;

			}
		}

		List<Bitmap> ZoomHistory = new List<Bitmap>(10);

		 Bitmap Orginal_IMG {get;set;}

		private double zoomFactor = 1.25;

		private int currentZoom = 0;

		[Browsable(true)]
		public Bitmap Image
		{
			get
			{
				if (this.ImagePB.Image != null)
				{
					Bitmap bmp = new Bitmap(this.ImagePB.Image);

					return bmp;
				}
				else return null;
			}
			set
			{
				ImagePB.Image = value;

			}
		}
		
	
		public Bitmap NewImage
		{
			get
			{
				if (this.ImagePB.Image != null)
				{
					Bitmap bmp = new Bitmap(this.ImagePB.Image);

					return bmp;
				}
				else return null;
			}
			set
			{
				ImagePB.Image = value;
				reset();
				init_Zoomed_Images();
				this.Orginal_IMG = Image;
			}
		}
		public void reset()
        {
			ZoomHistory.Clear();
			currentZoom = 0;
			
		}
		public void refrech_image()
        {

			this.NewImage = Orginal_IMG;

        }
	
	void init_Zoomed_Images()
        {
			ZoomHistory.Add(Image);

			for (int i = 1;i<5;i++)
            {
				if (i == 1)
				{
					int width = Convert.ToInt32(ImagePB.Image.Width * zoomFactor);
					int Height = Convert.ToInt32(ImagePB.Image.Height * zoomFactor);
					Bitmap _Image = ImageHelper.ResizeImage(width, Height, this.Image);
					ZoomHistory.Add(_Image);
				}
				else {

					int width = Convert.ToInt32(ZoomHistory[i - 1].Width * zoomFactor);
					int height = Convert.ToInt32(ZoomHistory[i - 1].Height * zoomFactor);
					Bitmap _Image = ImageHelper.ResizeImage(width, height, ZoomHistory[i - 1]);
					ZoomHistory.Add(_Image);


				}
			}

		}

		private void setZoomIn()
		{
			if (ZoomHistory.Any())
			{
				if ((currentZoom + 1 < 5))
				{
					currentZoom = currentZoom + 1;
					Image = ZoomHistory[currentZoom];
				}
			}
			
		}
		private void setZoomOut()
		{
			if (ZoomHistory.Any())
			{
				if ((currentZoom - 1 >= 0))
				{
					currentZoom = currentZoom - 1;
					Image = ZoomHistory[currentZoom];
				}
			}
		}

		private void scrollZoom_Scroll(object sender, MouseEventArgs args)
        {
			if (args.Delta > 0)
			{
				
			setZoomIn();
				
			}
			else
            {
				
			setZoomOut();

			}
		}
    }
}
