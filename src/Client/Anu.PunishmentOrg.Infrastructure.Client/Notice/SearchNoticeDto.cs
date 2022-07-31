namespace Anu.PunishmentOrg.Client.Infrastructure.Notice
{
    public readonly record struct SearchNoticeDto(string caseNo, string password);

    public readonly record struct NoticeInfoDto(string Branch, string ArchiveNo, string SubNo,String PersonInfo);


}

