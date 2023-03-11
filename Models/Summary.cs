using Azure.AI.TextAnalytics;

namespace BlazorSample.Models;

public class Summary
{
    public DetectedLanguage DetectedLanguage{ get; set; }
    public KeyPhraseCollection KeyPhraseCollection { get; set; }
    public List<SummarySentence> SummarySentence { get; set; } = new();
    public DocumentSentiment DocumentSentiment { get; set; }
}
