using MobilePaywall.ContentUploader.Video;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePaywall.VideoContentInserter
{
	class Program
	{
		// PATH TO THE CONTENT FOLDER
		public static string CONTENT_FOLDER = @"C:\Users\ako\Desktop\upload lorenc";
		// this folder must have "_config.txt" with prefiled informations

		static void Main(string[] args)
		{
			MobilePaywall.Data.Sql.Database db = null;
			Senti.Data.DataLayerRuntime runtime = new Senti.Data.DataLayerRuntime();
			VideoUploaderManager manager = new VideoUploaderManager(@"C:\Users\ako\Desktop\upload lorenc");
			manager.Start();

			Console.ReadKey();
		}
		



	}
}
