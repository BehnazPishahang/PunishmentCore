using Anu.BaseInfo.DataModel.Attachment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Anu.DataAccess;

namespace Anu.BaseInfo.DataAccess.GAttachment
{
    public class GAttachmentDataRepository: Anu.DataAccess.Repositories.GenericRepository<Anu.BaseInfo.DataModel.Attachment.GAttachmentData>, Anu.BaseInfo.Domain.GAttachment.IGAttachmentDataRepository
    {
        public GAttachmentDataRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task InsertIntoGAttachmentData(byte[] docfile)
        {
            StringBuilder hex = new StringBuilder(docfile.Length * 2);
            foreach (byte b in docfile)
                hex.AppendFormat("{0:x2}", b);
            
            //var P3 = BitConverter.ToString(docfile).Replace("-", "");
            var P3 = hex.ToString(); ;
            var p2 = Guid.NewGuid().ToString("N").Substring(0,20);
            var p1 = 1;
            var query = $"DECLARE str varchar2(32767) BEGIN str := hextoraw('{P3}'); INSERT INTO GAttachmentData (TIMESTAMP, ID, DOCFILE) VALUES ({p1},'{p2}',str); END;";

            await _context.Database.ExecuteSqlRawAsync(query);
        }
    }
}
