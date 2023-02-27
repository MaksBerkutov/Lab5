using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Module.ViewModel
{
    //Task3
    public partial class MainWindowViewModel
    {
        private string _syntaxInput;
        private string _syntaxResult;
        public Base.Command StartSyntax { get; }

        private async void StartSyntaxHandler(object obj)
        {
            await Logic.Syntax.SyntaAnalizeCallBackAsync(_syntaxInput, (G,S,D,P) => SyntaxResult = $"Result: Гласных {G} Согласных {S} Цифр {D} Пробелов {P}");
        }
        private bool CanStartSyntax(object obj) => !String.IsNullOrEmpty(_syntaxInput);
        public string SyntaxInput
        {
            get => _syntaxInput;
            set
            {
                _syntaxInput = value;
                OnPropertyChanged(nameof(SyntaxInput));
            }
        }
        public string SyntaxResult
        {
            get => _syntaxResult;
            set
            {
                _syntaxResult = value;
                OnPropertyChanged(nameof(SyntaxResult));
            }
        }
    }
    //Task2
    public partial class MainWindowViewModel
    {
        private string _resultStep;
        private long _inputStepNum = 0;
        private long _inputStep = 0;
        public Base.Command StartStep { get; }

        private async void StartStepHandler(object obj)
        {
            await Logic.Stepen.StepenAsync(_inputStepNum, _inputStepNum, x => ResultStep = $"Result: {x}");
        }
        private bool CanStartStep(object obj) => _inputStepNum > 0 && _inputStep>0;

        public string ResultStep
        {
            get => _resultStep;
            set
            {
                _resultStep = value;
                OnPropertyChanged(nameof(ResultStep));
            }
        }
        public long InputStepNum
        {
            get => _inputStepNum;
            set
            {
                _inputStepNum = value;
                OnPropertyChanged(nameof(InputStepNum));
            }
        }
        public long InputStep
        {
            get => _inputStep;
            set
            {
                _inputStep = value;
                OnPropertyChanged(nameof(InputStep));
            }
        }
    }
    //Task1
    public partial class MainWindowViewModel:Base.ViewModel
    {
        private string _resultFtrl;
        private long _inputFtrl = 0;
        public Base.Command StartFtrl { get; }
        

        public MainWindowViewModel()
        {
            StartSyntax = new Base.Command(StartSyntaxHandler, CanStartSyntax);
            StartFtrl = new Base.Command(StartFtrlHandler, CanStartFtrl);
            StartStep = new Base.Command(StartStepHandler, CanStartStep);
        }
        private async void StartFtrlHandler(object obj)
        {
            await Logic.Factorial.CalculateFactorialAsync(_inputFtrl,x=>ResultFtrl=$"Result: {x}");
        }
        private bool CanStartFtrl(object obj) =>  _inputFtrl > 0&&_inputFtrl<=64;
        public string ResultFtrl
        {
            get => _resultFtrl;
            set
            {
                _resultFtrl = value;
                OnPropertyChanged(nameof(ResultFtrl));
            }
        }
        public long InputFtrl
        {
            get => _inputFtrl;
            set
            {
                _inputFtrl = value;
                OnPropertyChanged(nameof(InputFtrl));
            }
        }
    }
}
