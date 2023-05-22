namespace Ublux.Communications.Models.EventTriggersModels;

/// <summary>
///     All webhook events must inherit from this
/// </summary>
public abstract class EventTriggerModel
{
    /// <summary>
    ///     Type of event. It only
    /// </summary>
    public abstract EventTriggerType EventTrigger
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
        var nameSb = new StringBuilder();

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
    public abstract EventTriggerModel BuildRandomFakeObject(RunningApplicationInstance instance);

    /// <summary>
    ///     Generate random id of account phone and line
    /// </summary>
    /// <param name="instance"></param>
    /// <param name="idAcc"></param>
    /// <param name="idPhone"></param>
    /// <param name="idLine"></param>
    protected static void GenerateRandomIdAccountPhoneAndLine(RunningApplicationInstance instance, out string idAcc, out string idPhone, out string idLine)
    {
        idPhone = Phone.BuildId(instance).Id;
        idAcc = Account.BuildId(Random.Shared.Next(100, 1000).ToString()).Id;
        idLine = Line.BuildId(instance, idAcc, idPhone).Id;
    }
}

