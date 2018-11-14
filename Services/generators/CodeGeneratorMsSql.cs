namespace DB2Code.Services.generators
{
    /// <summary>
    ///
    /// </summary>
    public class CodeGeneratorMsSql : CodeGeneratorBase
    {
        public override AccessDataBaseType DataBaseType
        {
            get { return AccessDataBaseType.MsSql; }
        }

        public CodeGeneratorMsSql(GeneratorOption option) : base(option)
        { }
    }
}