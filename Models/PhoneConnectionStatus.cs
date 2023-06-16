namespace Ublux.Communications.Models;

/// <summary>
///     Status of phone line
/// </summary>
public class PhoneConnectionStatus
{
    private static readonly ReaderWriterLockSlim _lock = new();

    private string? _ipWAN;
    private int _portWAN;
    private string? _ipLAN;
    private int _portLAN;
    private string? _userAgent;
    private bool _isConnected;
    private string? _disconnectedReason;
    private DateTime? _dateConnected;
    private DateTime? _dateDisconnected;

    /// <summary>
    ///     Public ip address of the connection
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? IpWAN
    {
        get
        {
            _lock.EnterReadLock();
            try
            {
                return _ipWAN;
            }
            finally
            {
                _lock.ExitReadLock();
            }
        }
        set
        {
            _lock.EnterWriteLock();
            try
            {
                _ipWAN = value;
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }
    }

    /// <summary>
    ///     Public port
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public int PortWAN
    {
        get
        {
            _lock.EnterReadLock();
            try
            {
                return _portWAN;
            }
            finally
            {
                _lock.ExitReadLock();
            }
        }
        set
        {
            _lock.EnterWriteLock();
            try
            {
                _portWAN = value;
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }
    }

    /// <summary>
    ///     Private ip address of the connection
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? IpLAN
    {
        get
        {
            _lock.EnterReadLock();
            try
            {
                return _ipLAN;
            }
            finally
            {
                _lock.ExitReadLock();
            }
        }
        set
        {
            _lock.EnterWriteLock();
            try
            {
                _ipLAN = value;
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }
    }

    /// <summary>
    ///     Private port
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public int PortLAN
    {
        get
        {
            _lock.EnterReadLock();
            try
            {
                return _portLAN;
            }
            finally
            {
                _lock.ExitReadLock();
            }
        }
        set
        {
            _lock.EnterWriteLock();
            try
            {
                _portLAN = value;
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }
    }

    /// <summary>
    ///     User agent of phone connecting
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? UserAgent
    {
        get
        {
            _lock.EnterReadLock();
            try
            {
                return _userAgent;
            }
            finally
            {
                _lock.ExitReadLock();
            }
        }
        set
        {
            _lock.EnterWriteLock();
            try
            {
                _userAgent = value;
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }
    }

    /// <summary>
    ///     Null means we do not know
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public bool IsConnected
    {
        get
        {
            _lock.EnterReadLock();
            try
            {
                return _isConnected;
            }
            finally
            {
                _lock.ExitReadLock();
            }
        }
        set
        {
            _lock.EnterWriteLock();
            try
            {
                _isConnected = value;
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }
    }

    /// <summary>
    ///     Reason of phone disconnected. 
    ///     Posible reasons: none, registration failure, remove existing, remove unavailable, expiration, request, shutdown
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public string? DisconnectedReason
    {
        get
        {
            _lock.EnterReadLock();
            try
            {
                return _disconnectedReason;
            }
            finally
            {
                _lock.ExitReadLock();
            }
        }
        set
        {
            _lock.EnterWriteLock();
            try
            {
                _disconnectedReason = value;
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }
    }

    /// <summary>
    ///     Date when line was last connected
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public DateTime? DateConnected
    {
        get
        {
            _lock.EnterReadLock();
            try
            {
                return _dateConnected;
            }
            finally
            {
                _lock.ExitReadLock();
            }
        }
        set
        {
            _lock.EnterWriteLock();
            try
            {
                _dateConnected = value;
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }
    }

    /// <summary>
    ///     Date when line was last disconnected
    /// </summary>
    [AllowUpdate(false)]
    [SwaggerSchema(ReadOnly = true)]
    public DateTime? DateDisconnected
    {
        get
        {
            _lock.EnterReadLock();
            try
            {
                return _dateDisconnected;
            }
            finally
            {
                _lock.ExitReadLock();
            }
        }
        set
        {
            _lock.EnterWriteLock();
            try
            {
                _dateDisconnected = value;
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }
    }

    // Have we sent sip notify? we send a sip notify if a phone does not send a packet for to long. 
    // Sending a sip notify will increase the probably of phone replying so we do not mark it as disconnected when in fact it is connected.
    private bool _sentSipNotify;
    /// <summary>
    ///     Set value of _sentSipNotify
    /// </summary>
    public void SetSentSipNofity(bool v) => _sentSipNotify = v;
    /// <summary>
    ///     Get value of _sentSipNotify
    /// </summary>
    public bool GetSentSipNofity() => _sentSipNotify;
}
