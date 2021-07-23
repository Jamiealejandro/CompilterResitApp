using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using static Compiler.Tokenization.TokenType;

namespace Compiler.Tokenization
{
  
    public enum TokenType
    {
        
        IntLiteral, Identifier, Operator, CharLiteral, Parameter,

        
        Begin, Const, Do, Else, End, If, In, Let, Then, Var, While, Wend, WendWhile, Pass, Endlet,

    
        Semicolon, Becomes, Is, LeftBracket, RightBracket,

     
        EndOfText, Error
    }

    
    public static class TokenTypes
    {
        
        public static ImmutableDictionary<string, TokenType> Keywords { get; } = new Dictionary<string, TokenType>()
        {
            { "begin", Begin },
            { "const", Const },
            { "do", Do },
            { "else", Else },
            { "end", End },
            { "if", If },
            { "in", In },
            { "let", Let },
            { "then", Then },
            { "var", Var },
            { "while", While },
            { "wend", Wend},
            { "wendwhile", WendWhile},
            { "pass", Pass },
            { "endlet", Endlet },
        }.ToImmutableDictionary();

        
        public static bool IsKeyword(StringBuilder word)
        {
            return Keywords.ContainsKey(word.ToString());
        }

        public static TokenType GetTokenForKeyword(StringBuilder word)
        {
            if (!IsKeyword(word)) throw new ArgumentException("Word is not a keyword");
            return Keywords[word.ToString()];
        }
    }
}
