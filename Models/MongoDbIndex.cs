namespace Ublux.Communications.Models;

/// <summary>
///     Mongo DB index so that we can execute search queries faster
/// </summary>
public class MongoDbIndex
{
    private readonly List<string[]> _properties = new();
    private readonly List<int> _sortOrders = new();

    /// <summary>
    ///     Example: Extensions
    /// </summary>
    public Collections Collection { get; set; }

    #region Constructors

    /// <summary>
    ///     Constructor
    /// </summary>
    public MongoDbIndex(Collections collection, int sortOrder, params string[] properties)
    {
        Collection = collection;
        if (sortOrder == 1 || sortOrder == -1)
        {
            // good valid sort order
            // sort order of 0 means text filter!
        }
        else
        {
            if (Debugger.IsAttached) Debugger.Break();
            throw new Exception("Invalid sort order. FKRO-DLK7");
        }

        _sortOrders.Add(sortOrder);
        _properties.Add(properties);
    }

    /// <summary>
    ///     Constructor overload with default soft order of 1
    /// </summary>
    public MongoDbIndex(Collections collection, params string[] properties) : this(collection, 1, properties)
    {
    }

    #endregion

    #region Add secondary index (Compound index)

    /// <summary>
    ///     Add a secondary index (this will be a compound index now)
    /// </summary>
    public MongoDbIndex Add(int sortOrder, params string[] properties)
    {
        if (sortOrder == 1 || sortOrder == -1)
        {
            // good valid sort order
            // sort order of 0 means text filter!
        }
        else
        {
            if (Debugger.IsAttached) Debugger.Break();
            throw new Exception("Invalid sort order. FKRO-DLK7");
        }

        _sortOrders.Add(sortOrder);
        _properties.Add(properties);

        return this;
    }
    /// <summary>
    ///     Add a secondary index with default sort order of 1 (this will be a compound index now)
    /// </summary>
    public MongoDbIndex Add(params string[] properties)
    {
        return Add(1, properties);
    }

    #endregion

    /// <summary>
    ///     Example: db.getCollection("AgreementsToTermsAndConditions").createIndex({ 'ubluxSession.idUser' : 1 })
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        StringBuilder sb = new();

        sb.Append('{');

        for (int i = 0; i < _properties.Count;)
        {
            // key and value
            {
                // key
                sb.Append('\"');
                sb.Append(string.Join('.', _properties[i].Select(x => x.FirstCharToLowerCase() ?? throw new Exception($"Invalid property name {x} FLE3-MNFY"))));
                sb.Append('\"');

                sb.Append(':');

                // value
                sb.Append(_sortOrders[i]);
            }
            

            // increment i
            i++;

            // if its a comound index and there are more index add comma
            if (i < _properties.Count)
                sb.Append(',');
        }

        sb.Append('}');

        return $"""
            db.getCollection("{Collection}").createIndex({sb});
            """;
    }
}


