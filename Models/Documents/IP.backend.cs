//#if UBLUX_BACKEND

//namespace Ublux.Communications.Models.Documents;

///// <summary>
/////     Ip address
///// </summary>
//public partial class IP : UbluxDocument
//{
//    /// <summary>
//    ///     In case there is a session the ublux user that has this ip
//    /// </summary>
//    [IgnoreDataMember]
//    [References(typeof(User))]
//    [AllowUpdate(false)]
//    public string? IdUser { get; set; }
    
//    /// <summary>
//    ///     PBX or device that block this ip. We set this when uploading this ip to WS.
//    /// </summary>
//    [IgnoreDataMember]
//    [AllowUpdate(false)]
//    public string? IpOrigin { get; set; }

//}

//#endif