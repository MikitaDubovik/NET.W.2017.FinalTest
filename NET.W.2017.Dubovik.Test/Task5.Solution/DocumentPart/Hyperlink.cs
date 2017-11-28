namespace Task5
{
    public class Hyperlink : DocumentPart
    {
        public string Url { get; set; }

        public override string Transform(ITransformer transformer)
        {
            return transformer.ConvertHyperlink(this.Text, this.Url);
        }
    }
}
