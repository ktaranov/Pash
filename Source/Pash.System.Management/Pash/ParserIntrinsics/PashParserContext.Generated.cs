﻿///////////////////////////////////////////////////////////////////
//
// Autogenerated file. Do not edit.
//
///////////////////////////////////////////////////////////////////


using System;
using System.Reflection;
using System.IO;
using System.Text;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;

using GoldParser;

namespace Pash.ParserIntrinsics
{
    public partial class PashParserContext
    {

        // instance fields
        private Parser m_parser;

        private TextReader m_inputReader;



        // constructor
        public PashParserContext(Parser parser)
        {
            m_parser = parser;
        }

        public string GetTokenText()
        {
            if (m_parser.TokenSymbol.SymbolType == SymbolType.Terminal) 
                return m_parser.TokenString;
            else
                return null;
        }

        public ASTNode CreateASTNode()
        {
            ASTNode node = null;
            
            switch (m_parser.ReductionRule.Index)
            {
                // <statementSeparatorToken> ::= NewLine <statementSeparatorToken>
                case 0:
                    CreateRule_Rule_Statementseparatortoken_Newline(m_parser, ref node);
                    return node;

                // <statementSeparatorToken> ::= 
                case 1:
                    CreateRule_Rule_Statementseparatortoken(m_parser, ref node);
                    return node;

                // <statementListRule> ::= <statementRule>
                case 2:
                    CreateRule_Rule_Statementlistrule(m_parser, ref node);
                    return node;

                // <statementListRule> ::= <statementRule> <statementSeparatorToken> <statementListRule>
                case 3:
                    CreateRule_Rule_Statementlistrule2(m_parser, ref node);
                    return node;

                // <statementRule> ::= <pipelineRule>
                case 4:
                    CreateRule_Rule_Statementrule(m_parser, ref node);
                    return node;

                // <statementRule> ::= CommentToken
                case 5:
                    CreateRule_Rule_Statementrule_Commenttoken(m_parser, ref node);
                    return node;

                // <pipelineRule> ::= <cmdletCall>
                case 6:
                    CreateRule_Rule_Pipelinerule(m_parser, ref node);
                    return node;

                // <pipelineRule> ::= <cmdletCall> '|' <pipelineRule>
                case 7:
                    CreateRule_Rule_Pipelinerule_Pipe(m_parser, ref node);
                    return node;

                // <pipelineRule> ::= <assignmentStatementRule>
                case 8:
                    CreateRule_Rule_Pipelinerule2(m_parser, ref node);
                    return node;

                // <pipelineRule> ::= <assignmentStatementRule> '|' <pipelineRule>
                case 9:
                    CreateRule_Rule_Pipelinerule_Pipe2(m_parser, ref node);
                    return node;

                // <assignmentStatementRule> ::= <lvalueExpression> AssignmentOperatorToken <pipelineRule>
                case 10:
                    CreateRule_Rule_Assignmentstatementrule_Assignmentoperatortoken(m_parser, ref node);
                    return node;

                // <lvalueExpression> ::= <lvalue>
                case 11:
                    CreateRule_Rule_Lvalueexpression(m_parser, ref node);
                    return node;

                // <lvalue> ::= <simpleLvalue>
                case 12:
                    CreateRule_Rule_Lvalue(m_parser, ref node);
                    return node;

                // <simpleLvalue> ::= VariableToken
                case 13:
                    CreateRule_Rule_Simplelvalue_Variabletoken(m_parser, ref node);
                    return node;

                // <ParameterArgumentToken> ::= <valueRule>
                case 14:
                    CreateRule_Rule_Parameterargumenttoken(m_parser, ref node);
                    return node;

                // <ParameterArgumentToken> ::= AnyWordToken
                case 15:
                    CreateRule_Rule_Parameterargumenttoken_Anywordtoken(m_parser, ref node);
                    return node;

                // <ParameterArgumentToken> ::= ParameterToken
                case 16:
                    CreateRule_Rule_Parameterargumenttoken_Parametertoken(m_parser, ref node);
                    return node;

                // <cmletParamsList> ::= <ParameterArgumentToken> <cmletParamsList>
                case 17:
                    CreateRule_Rule_Cmletparamslist(m_parser, ref node);
                    return node;

                // <cmletParamsList> ::= <ParameterArgumentToken>
                case 18:
                    CreateRule_Rule_Cmletparamslist2(m_parser, ref node);
                    return node;

                // <cmdletName> ::= AnyWordToken
                case 19:
                    CreateRule_Rule_Cmdletname_Anywordtoken(m_parser, ref node);
                    return node;

                // <cmdletCall> ::= ExecCall <cmdletName> <cmletParamsList>
                case 20:
                    CreateRule_Rule_Cmdletcall_Execcall(m_parser, ref node);
                    return node;

                // <cmdletCall> ::= ExecCall <cmdletName>
                case 21:
                    CreateRule_Rule_Cmdletcall_Execcall2(m_parser, ref node);
                    return node;

                // <cmdletCall> ::= <cmdletName> <cmletParamsList>
                case 22:
                    CreateRule_Rule_Cmdletcall(m_parser, ref node);
                    return node;

                // <cmdletCall> ::= <cmdletName>
                case 23:
                    CreateRule_Rule_Cmdletcall2(m_parser, ref node);
                    return node;

                // <cmdletCall> ::= <expressionRule>
                case 24:
                    CreateRule_Rule_Cmdletcall3(m_parser, ref node);
                    return node;

                // <expressionRule> ::= <logicalExpressionRule>
                case 25:
                    CreateRule_Rule_Expressionrule(m_parser, ref node);
                    return node;

                // <logicalExpressionRule> ::= <bitwiseExpressionRule>
                case 26:
                    CreateRule_Rule_Logicalexpressionrule(m_parser, ref node);
                    return node;

                // <bitwiseExpressionRule> ::= <comparisonExpressionRule>
                case 27:
                    CreateRule_Rule_Bitwiseexpressionrule(m_parser, ref node);
                    return node;

                // <comparisonExpressionRule> ::= <addExpressionRule>
                case 28:
                    CreateRule_Rule_Comparisonexpressionrule(m_parser, ref node);
                    return node;

                // <addExpressionRule> ::= <multiplyExpressionRule>
                case 29:
                    CreateRule_Rule_Addexpressionrule(m_parser, ref node);
                    return node;

                // <addExpressionRule> ::= <multiplyExpressionRule> AdditionOperatorToken <addExpressionRule>
                case 30:
                    CreateRule_Rule_Addexpressionrule_Additionoperatortoken(m_parser, ref node);
                    return node;

                // <multiplyExpressionRule> ::= <formatExpressionRule>
                case 31:
                    CreateRule_Rule_Multiplyexpressionrule(m_parser, ref node);
                    return node;

                // <formatExpressionRule> ::= <rangeExpressionRule>
                case 32:
                    CreateRule_Rule_Formatexpressionrule(m_parser, ref node);
                    return node;

                // <rangeExpressionRule> ::= <arrayLiteralRule>
                case 33:
                    CreateRule_Rule_Rangeexpressionrule(m_parser, ref node);
                    return node;

                // <rangeExpressionRule> ::= <arrayLiteralRule> RangeOperatorToken <rangeExpressionRule>
                case 34:
                    CreateRule_Rule_Rangeexpressionrule_Rangeoperatortoken(m_parser, ref node);
                    return node;

                // <arrayLiteralRule> ::= <postfixOperatorRule>
                case 35:
                    CreateRule_Rule_Arrayliteralrule(m_parser, ref node);
                    return node;

                // <arrayLiteralRule> ::= <postfixOperatorRule> CommaToken <arrayLiteralRule>
                case 36:
                    CreateRule_Rule_Arrayliteralrule_Commatoken(m_parser, ref node);
                    return node;

                // <postfixOperatorRule> ::= <propertyOrArrayReferenceRule>
                case 37:
                    CreateRule_Rule_Postfixoperatorrule(m_parser, ref node);
                    return node;

                // <propertyOrArrayReferenceRule> ::= <valueRule>
                case 38:
                    CreateRule_Rule_Propertyorarrayreferencerule(m_parser, ref node);
                    return node;

                // <valueRule> ::= StringToken
                case 39:
                    CreateRule_Rule_Valuerule_Stringtoken(m_parser, ref node);
                    return node;

                // <valueRule> ::= VariableToken
                case 40:
                    CreateRule_Rule_Valuerule_Variabletoken(m_parser, ref node);
                    return node;

                // <valueRule> ::= NumberToken
                case 41:
                    CreateRule_Rule_Valuerule_Numbertoken(m_parser, ref node);
                    return node;

                // <valueRule> ::= '$(' <statementRule> ')'
                case 42:
                    CreateRule_Rule_Valuerule_Dollarlparan_Rparan(m_parser, ref node);
                    return node;

                // <valueRule> ::= '(' <assignmentStatementRule> ')'
                case 43:
                    CreateRule_Rule_Valuerule_Lparan_Rparan(m_parser, ref node);
                    return node;

                default:
                    throw new RuleException("Unknown rule: Does your CGT Match your Code Revision?");
            }

        }
        
        #region CreateASTNode Dispatch hooks
        // <statementSeparatorToken> ::= NewLine <statementSeparatorToken>
        partial void CreateRule_Rule_Statementseparatortoken_Newline(Parser parser, ref ASTNode node);
        // <statementSeparatorToken> ::= 
        partial void CreateRule_Rule_Statementseparatortoken(Parser parser, ref ASTNode node);
        // <statementListRule> ::= <statementRule>
        partial void CreateRule_Rule_Statementlistrule(Parser parser, ref ASTNode node);
        // <statementListRule> ::= <statementRule> <statementSeparatorToken> <statementListRule>
        partial void CreateRule_Rule_Statementlistrule2(Parser parser, ref ASTNode node);
        // <statementRule> ::= <pipelineRule>
        partial void CreateRule_Rule_Statementrule(Parser parser, ref ASTNode node);
        // <statementRule> ::= CommentToken
        partial void CreateRule_Rule_Statementrule_Commenttoken(Parser parser, ref ASTNode node);
        // <pipelineRule> ::= <cmdletCall>
        partial void CreateRule_Rule_Pipelinerule(Parser parser, ref ASTNode node);
        // <pipelineRule> ::= <cmdletCall> '|' <pipelineRule>
        partial void CreateRule_Rule_Pipelinerule_Pipe(Parser parser, ref ASTNode node);
        // <pipelineRule> ::= <assignmentStatementRule>
        partial void CreateRule_Rule_Pipelinerule2(Parser parser, ref ASTNode node);
        // <pipelineRule> ::= <assignmentStatementRule> '|' <pipelineRule>
        partial void CreateRule_Rule_Pipelinerule_Pipe2(Parser parser, ref ASTNode node);
        // <assignmentStatementRule> ::= <lvalueExpression> AssignmentOperatorToken <pipelineRule>
        partial void CreateRule_Rule_Assignmentstatementrule_Assignmentoperatortoken(Parser parser, ref ASTNode node);
        // <lvalueExpression> ::= <lvalue>
        partial void CreateRule_Rule_Lvalueexpression(Parser parser, ref ASTNode node);
        // <lvalue> ::= <simpleLvalue>
        partial void CreateRule_Rule_Lvalue(Parser parser, ref ASTNode node);
        // <simpleLvalue> ::= VariableToken
        partial void CreateRule_Rule_Simplelvalue_Variabletoken(Parser parser, ref ASTNode node);
        // <ParameterArgumentToken> ::= <valueRule>
        partial void CreateRule_Rule_Parameterargumenttoken(Parser parser, ref ASTNode node);
        // <ParameterArgumentToken> ::= AnyWordToken
        partial void CreateRule_Rule_Parameterargumenttoken_Anywordtoken(Parser parser, ref ASTNode node);
        // <ParameterArgumentToken> ::= ParameterToken
        partial void CreateRule_Rule_Parameterargumenttoken_Parametertoken(Parser parser, ref ASTNode node);
        // <cmletParamsList> ::= <ParameterArgumentToken> <cmletParamsList>
        partial void CreateRule_Rule_Cmletparamslist(Parser parser, ref ASTNode node);
        // <cmletParamsList> ::= <ParameterArgumentToken>
        partial void CreateRule_Rule_Cmletparamslist2(Parser parser, ref ASTNode node);
        // <cmdletName> ::= AnyWordToken
        partial void CreateRule_Rule_Cmdletname_Anywordtoken(Parser parser, ref ASTNode node);
        // <cmdletCall> ::= ExecCall <cmdletName> <cmletParamsList>
        partial void CreateRule_Rule_Cmdletcall_Execcall(Parser parser, ref ASTNode node);
        // <cmdletCall> ::= ExecCall <cmdletName>
        partial void CreateRule_Rule_Cmdletcall_Execcall2(Parser parser, ref ASTNode node);
        // <cmdletCall> ::= <cmdletName> <cmletParamsList>
        partial void CreateRule_Rule_Cmdletcall(Parser parser, ref ASTNode node);
        // <cmdletCall> ::= <cmdletName>
        partial void CreateRule_Rule_Cmdletcall2(Parser parser, ref ASTNode node);
        // <cmdletCall> ::= <expressionRule>
        partial void CreateRule_Rule_Cmdletcall3(Parser parser, ref ASTNode node);
        // <expressionRule> ::= <logicalExpressionRule>
        partial void CreateRule_Rule_Expressionrule(Parser parser, ref ASTNode node);
        // <logicalExpressionRule> ::= <bitwiseExpressionRule>
        partial void CreateRule_Rule_Logicalexpressionrule(Parser parser, ref ASTNode node);
        // <bitwiseExpressionRule> ::= <comparisonExpressionRule>
        partial void CreateRule_Rule_Bitwiseexpressionrule(Parser parser, ref ASTNode node);
        // <comparisonExpressionRule> ::= <addExpressionRule>
        partial void CreateRule_Rule_Comparisonexpressionrule(Parser parser, ref ASTNode node);
        // <addExpressionRule> ::= <multiplyExpressionRule>
        partial void CreateRule_Rule_Addexpressionrule(Parser parser, ref ASTNode node);
        // <addExpressionRule> ::= <multiplyExpressionRule> AdditionOperatorToken <addExpressionRule>
        partial void CreateRule_Rule_Addexpressionrule_Additionoperatortoken(Parser parser, ref ASTNode node);
        // <multiplyExpressionRule> ::= <formatExpressionRule>
        partial void CreateRule_Rule_Multiplyexpressionrule(Parser parser, ref ASTNode node);
        // <formatExpressionRule> ::= <rangeExpressionRule>
        partial void CreateRule_Rule_Formatexpressionrule(Parser parser, ref ASTNode node);
        // <rangeExpressionRule> ::= <arrayLiteralRule>
        partial void CreateRule_Rule_Rangeexpressionrule(Parser parser, ref ASTNode node);
        // <rangeExpressionRule> ::= <arrayLiteralRule> RangeOperatorToken <rangeExpressionRule>
        partial void CreateRule_Rule_Rangeexpressionrule_Rangeoperatortoken(Parser parser, ref ASTNode node);
        // <arrayLiteralRule> ::= <postfixOperatorRule>
        partial void CreateRule_Rule_Arrayliteralrule(Parser parser, ref ASTNode node);
        // <arrayLiteralRule> ::= <postfixOperatorRule> CommaToken <arrayLiteralRule>
        partial void CreateRule_Rule_Arrayliteralrule_Commatoken(Parser parser, ref ASTNode node);
        // <postfixOperatorRule> ::= <propertyOrArrayReferenceRule>
        partial void CreateRule_Rule_Postfixoperatorrule(Parser parser, ref ASTNode node);
        // <propertyOrArrayReferenceRule> ::= <valueRule>
        partial void CreateRule_Rule_Propertyorarrayreferencerule(Parser parser, ref ASTNode node);
        // <valueRule> ::= StringToken
        partial void CreateRule_Rule_Valuerule_Stringtoken(Parser parser, ref ASTNode node);
        // <valueRule> ::= VariableToken
        partial void CreateRule_Rule_Valuerule_Variabletoken(Parser parser, ref ASTNode node);
        // <valueRule> ::= NumberToken
        partial void CreateRule_Rule_Valuerule_Numbertoken(Parser parser, ref ASTNode node);
        // <valueRule> ::= '$(' <statementRule> ')'
        partial void CreateRule_Rule_Valuerule_Dollarlparan_Rparan(Parser parser, ref ASTNode node);
        // <valueRule> ::= '(' <assignmentStatementRule> ')'
        partial void CreateRule_Rule_Valuerule_Lparan_Rparan(Parser parser, ref ASTNode node);
        #endregion

    }

}
