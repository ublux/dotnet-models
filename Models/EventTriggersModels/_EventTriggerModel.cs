namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     All webhook events must inherit from this
/// </summary>
public abstract class EventTriggerModel
{
    /// <summary>
    ///     Type of event. It only
    /// </summary>
    public abstract EventTrigger EventTrigger
    {
        get;
#if UBLUX_Release || RELEASE
        set;
#endif
    }

    /// <summary>
    ///     Id of document
    /// </summary>
    public required string Id { get; set; }

    /// <summary>
    ///     Converts EventOutgoingCallTerminated to OutgoingCallTerminated
    /// </summary>
    public static string EventTriggerToClassName(string webHookType)
    {
        StringBuilder nameSb = new StringBuilder();

        // skip event
        int i = 0;

        // firt letter must be uppercase
        nameSb.Append(char.ToUpper(webHookType[i]));
        i++;

        for (; i < webHookType.Length; i++)
        {
            if (webHookType[i] == '_')
            {
                i++;
                nameSb.Append(char.ToUpper(webHookType[i]));
            }
            else
            {
                nameSb.Append(webHookType[i]);
            }
        }

        var className = nameSb.ToString();
        return className;
    }

    /// <summary>
    ///     Return fake object used by Zapier to be shown as an example
    /// </summary>
    /// <returns></returns>
    public abstract EventTriggerModel BuildRandomFakeObject();    
}

