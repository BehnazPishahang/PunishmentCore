using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anu.BaseInfo.Domain.GAttachment;

public interface IGAttachmentDataRepository : Anu.Domain.IGenericRepository<Anu.BaseInfo.DataModel.Attachment.GAttachmentData>
{
    public Task InsertIntoGAttachmentData(byte[] docfile);

}
