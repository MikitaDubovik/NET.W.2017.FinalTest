namespace Task5
{
    public class BoldText : DocumentPart
    {
        public override string Transform(ITransformer transformer)
        {
            return transformer.ConvertToLaTeX(this.Text);
        }
    }
}