namespace Task5
{
    public class PlainText : DocumentPart
    {
        public override string Transform(ITransformer transformer)
        {
            return transformer.ConvertPlainText(this.Text);
        }
    }
}
