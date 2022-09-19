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
        }
    }
}
