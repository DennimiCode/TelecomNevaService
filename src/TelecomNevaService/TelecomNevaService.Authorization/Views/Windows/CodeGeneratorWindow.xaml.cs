using TelecomNevaService.Authorization.Classes;

namespace TelecomNevaService.Authorization.Views.Windows;

public partial class CodeGeneratorWindow
{
    public string Code { get; }

    public CodeGeneratorWindow(CodeGenerator codeGenerator, string windowName)
    {
        InitializeComponent();

        CodeLabel.Content = Code = codeGenerator.GenerateCode();
        Name = windowName;
    }
}