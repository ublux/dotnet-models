﻿#if UBLUX_BACKEND

namespace Ublux.Communications.Models;

/// <summary>
///     All collections on database must contain this attribute.
///     Represents a Table on a traditional database. 
///     Business Logic Models that we work with inherit from this. 
///     We need to work with what is stored on our application. 
///     DTO objects is what we present to clients
/// </summary>
public partial interface IUbluxDocument : IUbluxDocumentId
{
    /// <summary>
    ///     Date when item was deleted
    /// </summary>
    [AllowUpdate(false)]
    [JsonProperty(Order = 1001)]
    [IgnoreDataMember]
    DateTime? DateDeleted { get; set; }
}

/// <summary>
///     * This are business logic objects *
///     All collections on database must contain this attribute.
///     Represents a Table on a traditional database
/// </summary>
public abstract partial class UbluxDocument : IUbluxDocument, IUbluxDocumentId
{
    /// <summary>
    ///     Deletion Date
    /// </summary>
    [JsonProperty(Order = 1001)]
    [IgnoreDataMember]
    [AllowUpdate(false)]
    [HideForCreateRequest]
    public DateTime? DateDeleted { get; set; }

    /// <summary>
    ///     Used to generate ids. Placed in here because autogenerated-code makes used of this
    /// </summary>
    private static ulong _idGenerationCounter;

    /// <summary>
    ///     Increments counter and gets current id
    /// </summary>    
    public static string IdGlobalAutoIncrement()
    {
        return ToBase62(Interlocked.Increment(ref _idGenerationCounter));
    }

    /// <summary>
    ///     Get IdGlobal current value
    /// </summary>    
    public static ulong IdGlobalCurrentValue()
    {
        return Interlocked.Read(ref _idGenerationCounter);
    }

    /// <summary>
    ///     This is not thread safe. call this method before initializing database.
    /// </summary>
    [Obsolete("Only set once. Having an incorrect counter will result in duplicate ids")]
    public static void IdGlobalSetValue(ulong v)
    {
        _idGenerationCounter = v;
    }
    
}

#endif