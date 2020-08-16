using System;

namespace SDSD_DevProject_Test.Models
{
	public class UploadImage
	{
		public int Id { get; set; }
		public string ImagePath { get; set; }
		public Guid UploadId { get; set; }
		public UploadDoc Upload { get; set; }
	}
}