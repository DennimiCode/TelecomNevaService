using System;
using System.Collections.Generic;
using System.Text;

namespace TelecomNevaService.Authorization.Classes;

public class CodeGenerator
{
    private Random _random;

    private readonly List<char> _specialChars = new()
    {
        '!', '@', '#',
        '$', '%', '^',
        '&', '*', '(',
        ')', '-', '+',
        '=', '<', '>', '?'
    };

    public string GenerateCode(int codeLength = 8)
    {
        StringBuilder resultStringBuilder = new();
        _random = new Random();

        for (int i = 0; i < codeLength; i++)
        {
            int selectedCharType = _random.Next(0, 4);
            char selectedChar = selectedCharType switch
            {
                0 => (char)_random.Next('a', 'z'),
                1 => (char)_random.Next('A', 'Z'),
                2 => (char)_random.Next('0', '9' + 1),
                3 => _specialChars[_random.Next(0, _specialChars.Count - 1)],
                _ => '0'
            };

            resultStringBuilder.Append(selectedChar);
        }

        return resultStringBuilder.ToString();
    }
}