namespace Ublux.Communications.Models.Documents;

/// <summary>
///     Determines how will a call be AI processed. What questions will be asked to the AI engine
/// </summary>
public partial class AiCallAnalysisInput : UbluxDocument_ReferenceAccount_ReferenceTags
{
    /// <summary>
    ///     List of queries to ask AI engine about a call
    /// </summary>    
    [UbluxValidationRequired]
    [AllowUpdate(true)]
    public List<AiCallAnalysisVariableInput> Queries { get; set; } = new();

    /// <inheritdoc />
    public override IEnumerable<MongoDbIndex> GetMongoDbIndexes()
    {        
        // this collection
        var collection = this.GetType().GetCollectionUsedByType();

        // get all mandatory indexes
        foreach (var item in base.GetMandatoryIndexes(collection))
            yield return item;
    }
}
