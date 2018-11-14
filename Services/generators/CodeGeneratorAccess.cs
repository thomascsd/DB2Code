namespace DB2Code.Services.generators
{
    public class CodeGeneratorAccess : CodeGeneratorBase
    {
        public override AccessDataBaseType DataBaseType
        {
            get { return AccessDataBaseType.Access; }
        }

        public CodeGeneratorAccess(GeneratorOption option) : base(option)
        {
        }
    }
}