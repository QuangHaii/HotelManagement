using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Drawing;

namespace HotelManagement.Domain.Entities
{
	public class APIRequest
	{
		public string accountNo { get; set; }
		public string accountName { get; set; }
		public int acqId { get; set; }
		public int amount { get; set; }
		public string addInfo { get; set; }
		public string logo { get; set; }
		public string format { get; set; }
		public string template { get; set; }
		public string theme { get; set; }
		public static string ImageToBase64(Image image, ImageFormat format)
		{
			using (MemoryStream ms = new MemoryStream())
			{
				// Convert Image to byte[]
				image.Save(ms, format);
				byte[] imageBytes = ms.ToArray();

				// Convert byte[] to Base64 string
				string base64String = Convert.ToBase64String(imageBytes);

				// Get the appropriate MIME type
				string mimeType = GetMimeType(format);

				// Return the Base64 string with the MIME type prefix
				return $"data:{mimeType};base64,{base64String}";
			}
		}

		private static string GetMimeType(ImageFormat format)
		{
			if (format.Equals(ImageFormat.Jpeg))
			{
				return "image/jpeg";
			}
			else if (format.Equals(ImageFormat.Png))
			{
				return "image/png";
			}
			else if (format.Equals(ImageFormat.Bmp))
			{
				return "image/bmp";
			}
			else if (format.Equals(ImageFormat.Gif))
			{
				return "image/gif";
			}
			else if (format.Equals(ImageFormat.Tiff))
			{
				return "image/tiff";
			}
			else
			{
				throw new ArgumentOutOfRangeException("Unknown image format");
			}
		}

		public static Image Base64ToImage(string base64String)
		{
			byte[] imageBytes = Convert.FromBase64String(base64String);
			MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
			ms.Write(imageBytes, 0, imageBytes.Length);
			System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
			return image;
		}

	}


	public class Data
	{
		public int acpId { get; set; }
		public string accountName { get; set; }
		public string qrCode { get; set; }
		public string qrDataURL { get; set; }
	}

	public class ApiResponse
	{
		public string code { get; set; }
		public string desc { get; set; }
		public Data data { get; set; }
	}
}
