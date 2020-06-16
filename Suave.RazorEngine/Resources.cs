﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RazorEngine
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Resources
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("Microsoft.AspNetCore.Razor.Language.Resources", typeof(Resources).GetTypeInfo().Assembly);

        /// <summary>
        /// Register Tag Helpers for use in the current document.
        /// </summary>
        internal static string AddTagHelperDirective_Description
        {
            get => GetString("AddTagHelperDirective_Description");
        }

        /// <summary>
        /// Register Tag Helpers for use in the current document.
        /// </summary>
        internal static string FormatAddTagHelperDirective_Description()
            => GetString("AddTagHelperDirective_Description");

        /// <summary>
        /// Add tag helpers from the specified type name and assembly name. Specify '*' for the type name to include all tag helper types from the specified assembly.
        /// </summary>
        internal static string AddTagHelperDirective_StringToken_Description
        {
            get => GetString("AddTagHelperDirective_StringToken_Description");
        }

        /// <summary>
        /// Add tag helpers from the specified type name and assembly name. Specify '*' for the type name to include all tag helper types from the specified assembly.
        /// </summary>
        internal static string FormatAddTagHelperDirective_StringToken_Description()
            => GetString("AddTagHelperDirective_StringToken_Description");

        /// <summary>
        /// TypeName, AssemblyName
        /// </summary>
        internal static string AddTagHelperDirective_StringToken_Name
        {
            get => GetString("AddTagHelperDirective_StringToken_Name");
        }

        /// <summary>
        /// TypeName, AssemblyName
        /// </summary>
        internal static string FormatAddTagHelperDirective_StringToken_Name()
            => GetString("AddTagHelperDirective_StringToken_Name");

        /// <summary>
        /// Value cannot be null or an empty string.
        /// </summary>
        internal static string ArgumentCannotBeNullOrEmpty
        {
            get => GetString("ArgumentCannotBeNullOrEmpty");
        }

        /// <summary>
        /// Value cannot be null or an empty string.
        /// </summary>
        internal static string FormatArgumentCannotBeNullOrEmpty()
            => GetString("ArgumentCannotBeNullOrEmpty");

        /// <summary>
        /// Block cannot be built because a Type has not been specified in the BlockBuilder
        /// </summary>
        internal static string Block_Type_Not_Specified
        {
            get => GetString("Block_Type_Not_Specified");
        }

        /// <summary>
        /// Block cannot be built because a Type has not been specified in the BlockBuilder
        /// </summary>
        internal static string FormatBlock_Type_Not_Specified()
            => GetString("Block_Type_Not_Specified");

        /// <summary>
        /// Block directive '{0}' cannot be imported.
        /// </summary>
        internal static string BlockDirectiveCannotBeImported
        {
            get => GetString("BlockDirectiveCannotBeImported");
        }

        /// <summary>
        /// Block directive '{0}' cannot be imported.
        /// </summary>
        internal static string FormatBlockDirectiveCannotBeImported(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("BlockDirectiveCannotBeImported"), p0);

        /// <summary>
        /// code
        /// </summary>
        internal static string BlockName_Code
        {
            get => GetString("BlockName_Code");
        }

        /// <summary>
        /// code
        /// </summary>
        internal static string FormatBlockName_Code()
            => GetString("BlockName_Code");

        /// <summary>
        /// explicit expression
        /// </summary>
        internal static string BlockName_ExplicitExpression
        {
            get => GetString("BlockName_ExplicitExpression");
        }

        /// <summary>
        /// explicit expression
        /// </summary>
        internal static string FormatBlockName_ExplicitExpression()
            => GetString("BlockName_ExplicitExpression");

        /// <summary>
        /// Invalid newline sequence '{0}'. Support newline sequences are '\r\n' and '\n'.
        /// </summary>
        internal static string CodeWriter_InvalidNewLine
        {
            get => GetString("CodeWriter_InvalidNewLine");
        }

        /// <summary>
        /// Invalid newline sequence '{0}'. Support newline sequences are '\r\n' and '\n'.
        /// </summary>
        internal static string FormatCodeWriter_InvalidNewLine(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("CodeWriter_InvalidNewLine"), p0);

        /// <summary>
        /// &lt;&lt;character literal&gt;&gt;
        /// </summary>
        internal static string CSharpToken_CharacterLiteral
        {
            get => GetString("CSharpToken_CharacterLiteral");
        }

        /// <summary>
        /// &lt;&lt;character literal&gt;&gt;
        /// </summary>
        internal static string FormatCSharpToken_CharacterLiteral()
            => GetString("CSharpToken_CharacterLiteral");

        /// <summary>
        /// &lt;&lt;comment&gt;&gt;
        /// </summary>
        internal static string CSharpToken_Comment
        {
            get => GetString("CSharpToken_Comment");
        }

        /// <summary>
        /// &lt;&lt;comment&gt;&gt;
        /// </summary>
        internal static string FormatCSharpToken_Comment()
            => GetString("CSharpToken_Comment");

        /// <summary>
        /// &lt;&lt;identifier&gt;&gt;
        /// </summary>
        internal static string CSharpToken_Identifier
        {
            get => GetString("CSharpToken_Identifier");
        }

        /// <summary>
        /// &lt;&lt;identifier&gt;&gt;
        /// </summary>
        internal static string FormatCSharpToken_Identifier()
            => GetString("CSharpToken_Identifier");

        /// <summary>
        /// &lt;&lt;integer literal&gt;&gt;
        /// </summary>
        internal static string CSharpToken_IntegerLiteral
        {
            get => GetString("CSharpToken_IntegerLiteral");
        }

        /// <summary>
        /// &lt;&lt;integer literal&gt;&gt;
        /// </summary>
        internal static string FormatCSharpToken_IntegerLiteral()
            => GetString("CSharpToken_IntegerLiteral");

        /// <summary>
        /// &lt;&lt;keyword&gt;&gt;
        /// </summary>
        internal static string CSharpToken_Keyword
        {
            get => GetString("CSharpToken_Keyword");
        }

        /// <summary>
        /// &lt;&lt;keyword&gt;&gt;
        /// </summary>
        internal static string FormatCSharpToken_Keyword()
            => GetString("CSharpToken_Keyword");

        /// <summary>
        /// &lt;&lt;newline sequence&gt;&gt;
        /// </summary>
        internal static string CSharpToken_Newline
        {
            get => GetString("CSharpToken_Newline");
        }

        /// <summary>
        /// &lt;&lt;newline sequence&gt;&gt;
        /// </summary>
        internal static string FormatCSharpToken_Newline()
            => GetString("CSharpToken_Newline");

        /// <summary>
        /// &lt;&lt;real literal&gt;&gt;
        /// </summary>
        internal static string CSharpToken_RealLiteral
        {
            get => GetString("CSharpToken_RealLiteral");
        }

        /// <summary>
        /// &lt;&lt;real literal&gt;&gt;
        /// </summary>
        internal static string FormatCSharpToken_RealLiteral()
            => GetString("CSharpToken_RealLiteral");

        /// <summary>
        /// &lt;&lt;string literal&gt;&gt;
        /// </summary>
        internal static string CSharpToken_StringLiteral
        {
            get => GetString("CSharpToken_StringLiteral");
        }

        /// <summary>
        /// &lt;&lt;string literal&gt;&gt;
        /// </summary>
        internal static string FormatCSharpToken_StringLiteral()
            => GetString("CSharpToken_StringLiteral");

        /// <summary>
        /// &lt;&lt;white space&gt;&gt;
        /// </summary>
        internal static string CSharpToken_Whitespace
        {
            get => GetString("CSharpToken_Whitespace");
        }

        /// <summary>
        /// &lt;&lt;white space&gt;&gt;
        /// </summary>
        internal static string FormatCSharpToken_Whitespace()
            => GetString("CSharpToken_Whitespace");

        /// <summary>
        /// The document type '{0}' does not support the extension '{1}'.
        /// </summary>
        internal static string Diagnostic_CodeTarget_UnsupportedExtension
        {
            get => GetString("Diagnostic_CodeTarget_UnsupportedExtension");
        }

        /// <summary>
        /// The document type '{0}' does not support the extension '{1}'.
        /// </summary>
        internal static string FormatDiagnostic_CodeTarget_UnsupportedExtension(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("Diagnostic_CodeTarget_UnsupportedExtension"), p0, p1);

        /// <summary>
        /// Invalid directive keyword '{0}'. Directives must have a non-empty keyword that consists only of letters.
        /// </summary>
        internal static string DirectiveDescriptor_InvalidDirectiveKeyword
        {
            get => GetString("DirectiveDescriptor_InvalidDirectiveKeyword");
        }

        /// <summary>
        /// Invalid directive keyword '{0}'. Directives must have a non-empty keyword that consists only of letters.
        /// </summary>
        internal static string FormatDirectiveDescriptor_InvalidDirectiveKeyword(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("DirectiveDescriptor_InvalidDirectiveKeyword"), p0);

        /// <summary>
        /// A non-optional directive token cannot follow an optional directive token.
        /// </summary>
        internal static string DirectiveDescriptor_InvalidNonOptionalToken
        {
            get => GetString("DirectiveDescriptor_InvalidNonOptionalToken");
        }

        /// <summary>
        /// A non-optional directive token cannot follow an optional directive token.
        /// </summary>
        internal static string FormatDirectiveDescriptor_InvalidNonOptionalToken()
            => GetString("DirectiveDescriptor_InvalidNonOptionalToken");

        /// <summary>
        /// The '{0}' directive expects an identifier.
        /// </summary>
        internal static string DirectiveExpectsIdentifier
        {
            get => GetString("DirectiveExpectsIdentifier");
        }

        /// <summary>
        /// The '{0}' directive expects an identifier.
        /// </summary>
        internal static string FormatDirectiveExpectsIdentifier(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("DirectiveExpectsIdentifier"), p0);

        /// <summary>
        /// The '{0}' directive expects a namespace name.
        /// </summary>
        internal static string DirectiveExpectsNamespace
        {
            get => GetString("DirectiveExpectsNamespace");
        }

        /// <summary>
        /// The '{0}' directive expects a namespace name.
        /// </summary>
        internal static string FormatDirectiveExpectsNamespace(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("DirectiveExpectsNamespace"), p0);

        /// <summary>
        /// The '{0}' directive expects a string surrounded by double quotes.
        /// </summary>
        internal static string DirectiveExpectsQuotedStringLiteral
        {
            get => GetString("DirectiveExpectsQuotedStringLiteral");
        }

        /// <summary>
        /// The '{0}' directive expects a string surrounded by double quotes.
        /// </summary>
        internal static string FormatDirectiveExpectsQuotedStringLiteral(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("DirectiveExpectsQuotedStringLiteral"), p0);

        /// <summary>
        /// The '{0}' directive expects a type name.
        /// </summary>
        internal static string DirectiveExpectsTypeName
        {
            get => GetString("DirectiveExpectsTypeName");
        }

        /// <summary>
        /// The '{0}' directive expects a type name.
        /// </summary>
        internal static string FormatDirectiveExpectsTypeName(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("DirectiveExpectsTypeName"), p0);

        /// <summary>
        /// The '{0}` directive must appear at the start of the line.
        /// </summary>
        internal static string DirectiveMustAppearAtStartOfLine
        {
            get => GetString("DirectiveMustAppearAtStartOfLine");
        }

        /// <summary>
        /// The '{0}` directive must appear at the start of the line.
        /// </summary>
        internal static string FormatDirectiveMustAppearAtStartOfLine(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("DirectiveMustAppearAtStartOfLine"), p0);

        /// <summary>
        /// The '{0}' directives value(s) must be separated by whitespace.
        /// </summary>
        internal static string DirectiveTokensMustBeSeparatedByWhitespace
        {
            get => GetString("DirectiveTokensMustBeSeparatedByWhitespace");
        }

        /// <summary>
        /// The '{0}' directives value(s) must be separated by whitespace.
        /// </summary>
        internal static string FormatDirectiveTokensMustBeSeparatedByWhitespace(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("DirectiveTokensMustBeSeparatedByWhitespace"), p0);

        /// <summary>
        /// The document of kind '{0}' does not have a '{1}'. The document classifier must set a value for '{2}'.
        /// </summary>
        internal static string DocumentMissingTarget
        {
            get => GetString("DocumentMissingTarget");
        }

        /// <summary>
        /// The document of kind '{0}' does not have a '{1}'. The document classifier must set a value for '{2}'.
        /// </summary>
        internal static string FormatDocumentMissingTarget(object p0, object p1, object p2)
            => string.Format(CultureInfo.CurrentCulture, GetString("DocumentMissingTarget"), p0, p1, p2);

        /// <summary>
        /// The '{0}' directive may only occur once per document.
        /// </summary>
        internal static string DuplicateDirective
        {
            get => GetString("DuplicateDirective");
        }

        /// <summary>
        /// The '{0}' directive may only occur once per document.
        /// </summary>
        internal static string FormatDuplicateDirective(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("DuplicateDirective"), p0);

        /// <summary>
        /// "EndBlock" was called without a matching call to "StartBlock".
        /// </summary>
        internal static string EndBlock_Called_Without_Matching_StartBlock
        {
            get => GetString("EndBlock_Called_Without_Matching_StartBlock");
        }

        /// <summary>
        /// "EndBlock" was called without a matching call to "StartBlock".
        /// </summary>
        internal static string FormatEndBlock_Called_Without_Matching_StartBlock()
            => GetString("EndBlock_Called_Without_Matching_StartBlock");

        /// <summary>
        /// line break
        /// </summary>
        internal static string ErrorComponent_Newline
        {
            get => GetString("ErrorComponent_Newline");
        }

        /// <summary>
        /// line break
        /// </summary>
        internal static string FormatErrorComponent_Newline()
            => GetString("ErrorComponent_Newline");

        /// <summary>
        /// The '{0}' feature requires a '{1}' provided by the '{2}'.
        /// </summary>
        internal static string FeatureDependencyMissing
        {
            get => GetString("FeatureDependencyMissing");
        }

        /// <summary>
        /// The '{0}' feature requires a '{1}' provided by the '{2}'.
        /// </summary>
        internal static string FormatFeatureDependencyMissing(object p0, object p1, object p2)
            => string.Format(CultureInfo.CurrentCulture, GetString("FeatureDependencyMissing"), p0, p1, p2);

        /// <summary>
        /// The feature must be initialized by setting the '{0}' property.
        /// </summary>
        internal static string FeatureMustBeInitialized
        {
            get => GetString("FeatureMustBeInitialized");
        }

        /// <summary>
        /// The feature must be initialized by setting the '{0}' property.
        /// </summary>
        internal static string FormatFeatureMustBeInitialized(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("FeatureMustBeInitialized"), p0);

        /// <summary>
        /// Specify a C# code block.
        /// </summary>
        internal static string FunctionsDirective_Description
        {
            get => GetString("FunctionsDirective_Description");
        }

        /// <summary>
        /// Specify a C# code block.
        /// </summary>
        internal static string FormatFunctionsDirective_Description()
            => GetString("FunctionsDirective_Description");

        /// <summary>
        /// &lt;&lt;newline sequence&gt;&gt;
        /// </summary>
        internal static string HtmlToken_NewLine
        {
            get => GetString("HtmlToken_NewLine");
        }

        /// <summary>
        /// &lt;&lt;newline sequence&gt;&gt;
        /// </summary>
        internal static string FormatHtmlToken_NewLine()
            => GetString("HtmlToken_NewLine");

        /// <summary>
        /// &lt;&lt;razor comment&gt;&gt;
        /// </summary>
        internal static string HtmlToken_RazorComment
        {
            get => GetString("HtmlToken_RazorComment");
        }

        /// <summary>
        /// &lt;&lt;razor comment&gt;&gt;
        /// </summary>
        internal static string FormatHtmlToken_RazorComment()
            => GetString("HtmlToken_RazorComment");

        /// <summary>
        /// &lt;&lt;text&gt;&gt;
        /// </summary>
        internal static string HtmlToken_Text
        {
            get => GetString("HtmlToken_Text");
        }

        /// <summary>
        /// &lt;&lt;text&gt;&gt;
        /// </summary>
        internal static string FormatHtmlToken_Text()
            => GetString("HtmlToken_Text");

        /// <summary>
        /// &lt;&lt;white space&gt;&gt;
        /// </summary>
        internal static string HtmlToken_WhiteSpace
        {
            get => GetString("HtmlToken_WhiteSpace");
        }

        /// <summary>
        /// &lt;&lt;white space&gt;&gt;
        /// </summary>
        internal static string FormatHtmlToken_WhiteSpace()
            => GetString("HtmlToken_WhiteSpace");

        /// <summary>
        /// Specify the base class for the current document.
        /// </summary>
        internal static string InheritsDirective_Description
        {
            get => GetString("InheritsDirective_Description");
        }

        /// <summary>
        /// Specify the base class for the current document.
        /// </summary>
        internal static string FormatInheritsDirective_Description()
            => GetString("InheritsDirective_Description");

        /// <summary>
        /// The base type that the current page inherits.
        /// </summary>
        internal static string InheritsDirective_TypeToken_Description
        {
            get => GetString("InheritsDirective_TypeToken_Description");
        }

        /// <summary>
        /// The base type that the current page inherits.
        /// </summary>
        internal static string FormatInheritsDirective_TypeToken_Description()
            => GetString("InheritsDirective_TypeToken_Description");

        /// <summary>
        /// TypeName
        /// </summary>
        internal static string InheritsDirective_TypeToken_Name
        {
            get => GetString("InheritsDirective_TypeToken_Name");
        }

        /// <summary>
        /// TypeName
        /// </summary>
        internal static string FormatInheritsDirective_TypeToken_Name()
            => GetString("InheritsDirective_TypeToken_Name");

        /// <summary>
        /// The '{0}' operation is not valid when the builder is empty.
        /// </summary>
        internal static string IntermediateNodeBuilder_PopInvalid
        {
            get => GetString("IntermediateNodeBuilder_PopInvalid");
        }

        /// <summary>
        /// The '{0}' operation is not valid when the builder is empty.
        /// </summary>
        internal static string FormatIntermediateNodeBuilder_PopInvalid(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("IntermediateNodeBuilder_PopInvalid"), p0);

        /// <summary>
        /// The node '{0}' has a read-only child collection and cannot be modified.
        /// </summary>
        internal static string IntermediateNodeReference_CollectionIsReadOnly
        {
            get => GetString("IntermediateNodeReference_CollectionIsReadOnly");
        }

        /// <summary>
        /// The node '{0}' has a read-only child collection and cannot be modified.
        /// </summary>
        internal static string FormatIntermediateNodeReference_CollectionIsReadOnly(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("IntermediateNodeReference_CollectionIsReadOnly"), p0);

        /// <summary>
        /// The reference is invalid. The node '{0}' could not be found as a child of '{1}'.
        /// </summary>
        internal static string IntermediateNodeReference_NodeNotFound
        {
            get => GetString("IntermediateNodeReference_NodeNotFound");
        }

        /// <summary>
        /// The reference is invalid. The node '{0}' could not be found as a child of '{1}'.
        /// </summary>
        internal static string FormatIntermediateNodeReference_NodeNotFound(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("IntermediateNodeReference_NodeNotFound"), p0, p1);

        /// <summary>
        /// The reference is invalid. References initialized with the default constructor cannot modify nodes.
        /// </summary>
        internal static string IntermediateNodeReference_NotInitialized
        {
            get => GetString("IntermediateNodeReference_NotInitialized");
        }

        /// <summary>
        /// The reference is invalid. References initialized with the default constructor cannot modify nodes.
        /// </summary>
        internal static string FormatIntermediateNodeReference_NotInitialized()
            => GetString("IntermediateNodeReference_NotInitialized");

        /// <summary>
        /// The '{0}' node type can only be used as a direct child of a '{1}' node.
        /// </summary>
        internal static string IntermediateNodes_InvalidParentNode
        {
            get => GetString("IntermediateNodes_InvalidParentNode");
        }

        /// <summary>
        /// The '{0}' node type can only be used as a direct child of a '{1}' node.
        /// </summary>
        internal static string FormatIntermediateNodes_InvalidParentNode(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("IntermediateNodes_InvalidParentNode"), p0, p1);

        /// <summary>
        /// The node '{0}' is not the owner of change '{1}'.
        /// </summary>
        internal static string InvalidOperation_SpanIsNotChangeOwner
        {
            get => GetString("InvalidOperation_SpanIsNotChangeOwner");
        }

        /// <summary>
        /// The node '{0}' is not the owner of change '{1}'.
        /// </summary>
        internal static string FormatInvalidOperation_SpanIsNotChangeOwner(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("InvalidOperation_SpanIsNotChangeOwner"), p0, p1);

        /// <summary>
        /// Invalid tag helper directive look up text '{0}'. The correct look up text format is: "name, assemblyName".
        /// </summary>
        internal static string InvalidTagHelperLookupText
        {
            get => GetString("InvalidTagHelperLookupText");
        }

        /// <summary>
        /// Invalid tag helper directive look up text '{0}'. The correct look up text format is: "name, assemblyName".
        /// </summary>
        internal static string FormatInvalidTagHelperLookupText(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("InvalidTagHelperLookupText"), p0);

        /// <summary>
        /// Invalid tag helper directive '{0}' value. '{1}' is not allowed in prefix '{2}'.
        /// </summary>
        internal static string InvalidTagHelperPrefixValue
        {
            get => GetString("InvalidTagHelperPrefixValue");
        }

        /// <summary>
        /// Invalid tag helper directive '{0}' value. '{1}' is not allowed in prefix '{2}'.
        /// </summary>
        internal static string FormatInvalidTagHelperPrefixValue(object p0, object p1, object p2)
            => string.Format(CultureInfo.CurrentCulture, GetString("InvalidTagHelperPrefixValue"), p0, p1, p2);

        /// <summary>
        /// The key must not be null.
        /// </summary>
        internal static string KeyMustNotBeNull
        {
            get => GetString("KeyMustNotBeNull");
        }

        /// <summary>
        /// The key must not be null.
        /// </summary>
        internal static string FormatKeyMustNotBeNull()
            => GetString("KeyMustNotBeNull");

        /// <summary>
        /// Cannot use built-in RazorComment handler, language characteristics does not define the CommentStart, CommentStar and CommentBody known token types or parser does not override TokenizerBackedParser.OutputSpanBeforeRazorComment
        /// </summary>
        internal static string Language_Does_Not_Support_RazorComment
        {
            get => GetString("Language_Does_Not_Support_RazorComment");
        }

        /// <summary>
        /// Cannot use built-in RazorComment handler, language characteristics does not define the CommentStart, CommentStar and CommentBody known token types or parser does not override TokenizerBackedParser.OutputSpanBeforeRazorComment
        /// </summary>
        internal static string FormatLanguage_Does_Not_Support_RazorComment()
            => GetString("Language_Does_Not_Support_RazorComment");

        /// <summary>
        /// The specified encoding '{0}' does not match the content's encoding '{1}'.
        /// </summary>
        internal static string MismatchedContentEncoding
        {
            get => GetString("MismatchedContentEncoding");
        }

        /// <summary>
        /// The specified encoding '{0}' does not match the content's encoding '{1}'.
        /// </summary>
        internal static string FormatMismatchedContentEncoding(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("MismatchedContentEncoding"), p0, p1);

        /// <summary>
        /// The "@" character must be followed by a ":", "(", or a C# identifier.  If you intended to switch to markup, use an HTML start tag, for example:
        /// 
        /// @if(isLoggedIn) {{
        ///     &lt;p&gt;Hello, @user!&lt;/p&gt;
        /// }}
        /// </summary>
        internal static string ParseError_AtInCode_Must_Be_Followed_By_Colon_Paren_Or_Identifier_Start
        {
            get => GetString("ParseError_AtInCode_Must_Be_Followed_By_Colon_Paren_Or_Identifier_Start");
        }

        /// <summary>
        /// The "@" character must be followed by a ":", "(", or a C# identifier.  If you intended to switch to markup, use an HTML start tag, for example:
        /// 
        /// @if(isLoggedIn) {{
        ///     &lt;p&gt;Hello, @user!&lt;/p&gt;
        /// }}
        /// </summary>
        internal static string FormatParseError_AtInCode_Must_Be_Followed_By_Colon_Paren_Or_Identifier_Start()
            => GetString("ParseError_AtInCode_Must_Be_Followed_By_Colon_Paren_Or_Identifier_Start");

        /// <summary>
        /// End of file was reached before the end of the block comment.  All comments started with "/*" sequence must be terminated with a matching "*/" sequence.
        /// </summary>
        internal static string ParseError_BlockComment_Not_Terminated
        {
            get => GetString("ParseError_BlockComment_Not_Terminated");
        }

        /// <summary>
        /// End of file was reached before the end of the block comment.  All comments started with "/*" sequence must be terminated with a matching "*/" sequence.
        /// </summary>
        internal static string FormatParseError_BlockComment_Not_Terminated()
            => GetString("ParseError_BlockComment_Not_Terminated");

        /// <summary>
        /// Directive '{0}' must have a value.
        /// </summary>
        internal static string ParseError_DirectiveMustHaveValue
        {
            get => GetString("ParseError_DirectiveMustHaveValue");
        }

        /// <summary>
        /// Directive '{0}' must have a value.
        /// </summary>
        internal static string FormatParseError_DirectiveMustHaveValue(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("ParseError_DirectiveMustHaveValue"), p0);

        /// <summary>
        /// An opening "{0}" is missing the corresponding closing "{1}".
        /// </summary>
        internal static string ParseError_Expected_CloseBracket_Before_EOF
        {
            get => GetString("ParseError_Expected_CloseBracket_Before_EOF");
        }

        /// <summary>
        /// An opening "{0}" is missing the corresponding closing "{1}".
        /// </summary>
        internal static string FormatParseError_Expected_CloseBracket_Before_EOF(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("ParseError_Expected_CloseBracket_Before_EOF"), p0, p1);

        /// <summary>
        /// The {0} block is missing a closing "{1}" character.  Make sure you have a matching "{1}" character for all the "{2}" characters within this block, and that none of the "{1}" characters are being interpreted as markup.
        /// </summary>
        internal static string ParseError_Expected_EndOfBlock_Before_EOF
        {
            get => GetString("ParseError_Expected_EndOfBlock_Before_EOF");
        }

        /// <summary>
        /// The {0} block is missing a closing "{1}" character.  Make sure you have a matching "{1}" character for all the "{2}" characters within this block, and that none of the "{1}" characters are being interpreted as markup.
        /// </summary>
        internal static string FormatParseError_Expected_EndOfBlock_Before_EOF(object p0, object p1, object p2)
            => string.Format(CultureInfo.CurrentCulture, GetString("ParseError_Expected_EndOfBlock_Before_EOF"), p0, p1, p2);

        /// <summary>
        /// The {0} directive is not supported.
        /// </summary>
        internal static string ParseError_HelperDirectiveNotAvailable
        {
            get => GetString("ParseError_HelperDirectiveNotAvailable");
        }

        /// <summary>
        /// The {0} directive is not supported.
        /// </summary>
        internal static string FormatParseError_HelperDirectiveNotAvailable(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("ParseError_HelperDirectiveNotAvailable"), p0);

        /// <summary>
        /// Optional quote around the directive '{0}' is missing the corresponding opening or closing quote.
        /// </summary>
        internal static string ParseError_IncompleteQuotesAroundDirective
        {
            get => GetString("ParseError_IncompleteQuotesAroundDirective");
        }

        /// <summary>
        /// Optional quote around the directive '{0}' is missing the corresponding opening or closing quote.
        /// </summary>
        internal static string FormatParseError_IncompleteQuotesAroundDirective(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("ParseError_IncompleteQuotesAroundDirective"), p0);

        /// <summary>
        /// Inline markup blocks (@&lt;p&gt;Content&lt;/p&gt;) cannot be nested.  Only one level of inline markup is allowed.
        /// </summary>
        internal static string ParseError_InlineMarkup_Blocks_Cannot_Be_Nested
        {
            get => GetString("ParseError_InlineMarkup_Blocks_Cannot_Be_Nested");
        }

        /// <summary>
        /// Inline markup blocks (@&lt;p&gt;Content&lt;/p&gt;) cannot be nested.  Only one level of inline markup is allowed.
        /// </summary>
        internal static string FormatParseError_InlineMarkup_Blocks_Cannot_Be_Nested()
            => GetString("ParseError_InlineMarkup_Blocks_Cannot_Be_Nested");

        /// <summary>
        /// Markup in a code block must start with a tag and all start tags must be matched with end tags.  Do not use unclosed tags like "&lt;br&gt;".  Instead use self-closing tags like "&lt;br/&gt;".
        /// </summary>
        internal static string ParseError_MarkupBlock_Must_Start_With_Tag
        {
            get => GetString("ParseError_MarkupBlock_Must_Start_With_Tag");
        }

        /// <summary>
        /// Markup in a code block must start with a tag and all start tags must be matched with end tags.  Do not use unclosed tags like "&lt;br&gt;".  Instead use self-closing tags like "&lt;br/&gt;".
        /// </summary>
        internal static string FormatParseError_MarkupBlock_Must_Start_With_Tag()
            => GetString("ParseError_MarkupBlock_Must_Start_With_Tag");

        /// <summary>
        /// The "{0}" element was not closed.  All elements must be either self-closing or have a matching end tag.
        /// </summary>
        internal static string ParseError_MissingEndTag
        {
            get => GetString("ParseError_MissingEndTag");
        }

        /// <summary>
        /// The "{0}" element was not closed.  All elements must be either self-closing or have a matching end tag.
        /// </summary>
        internal static string FormatParseError_MissingEndTag(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("ParseError_MissingEndTag"), p0);

        /// <summary>
        /// Namespace imports and type aliases cannot be placed within code blocks.  They must immediately follow an "@" character in markup.  It is recommended that you put them at the top of the page, as in the following example:
        /// 
        /// @using System.Drawing;
        /// @{{
        ///     // OK here to use types from System.Drawing in the page.
        /// }}
        /// </summary>
        internal static string ParseError_NamespaceImportAndTypeAlias_Cannot_Exist_Within_CodeBlock
        {
            get => GetString("ParseError_NamespaceImportAndTypeAlias_Cannot_Exist_Within_CodeBlock");
        }

        /// <summary>
        /// Namespace imports and type aliases cannot be placed within code blocks.  They must immediately follow an "@" character in markup.  It is recommended that you put them at the top of the page, as in the following example:
        /// 
        /// @using System.Drawing;
        /// @{{
        ///     // OK here to use types from System.Drawing in the page.
        /// }}
        /// </summary>
        internal static string FormatParseError_NamespaceImportAndTypeAlias_Cannot_Exist_Within_CodeBlock()
            => GetString("ParseError_NamespaceImportAndTypeAlias_Cannot_Exist_Within_CodeBlock");

        /// <summary>
        /// Outer tag is missing a name. The first character of a markup block must be an HTML tag with a valid name.
        /// </summary>
        internal static string ParseError_OuterTagMissingName
        {
            get => GetString("ParseError_OuterTagMissingName");
        }

        /// <summary>
        /// Outer tag is missing a name. The first character of a markup block must be an HTML tag with a valid name.
        /// </summary>
        internal static string FormatParseError_OuterTagMissingName()
            => GetString("ParseError_OuterTagMissingName");

        /// <summary>
        /// End of file was reached before the end of the block comment.  All comments that start with the "@*" sequence must be terminated with a matching "*@" sequence.
        /// </summary>
        internal static string ParseError_RazorComment_Not_Terminated
        {
            get => GetString("ParseError_RazorComment_Not_Terminated");
        }

        /// <summary>
        /// End of file was reached before the end of the block comment.  All comments that start with the "@*" sequence must be terminated with a matching "*@" sequence.
        /// </summary>
        internal static string FormatParseError_RazorComment_Not_Terminated()
            => GetString("ParseError_RazorComment_Not_Terminated");

        /// <summary>
        /// "{0}" is a reserved word and cannot be used in implicit expressions.  An explicit expression ("@()") must be used.
        /// </summary>
        internal static string ParseError_ReservedWord
        {
            get => GetString("ParseError_ReservedWord");
        }

        /// <summary>
        /// "{0}" is a reserved word and cannot be used in implicit expressions.  An explicit expression ("@()") must be used.
        /// </summary>
        internal static string FormatParseError_ReservedWord(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("ParseError_ReservedWord"), p0);

        /// <summary>
        /// Section blocks ("{0}") cannot be nested.  Only one level of section blocks are allowed.
        /// </summary>
        internal static string ParseError_Sections_Cannot_Be_Nested
        {
            get => GetString("ParseError_Sections_Cannot_Be_Nested");
        }

        /// <summary>
        /// Section blocks ("{0}") cannot be nested.  Only one level of section blocks are allowed.
        /// </summary>
        internal static string FormatParseError_Sections_Cannot_Be_Nested(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("ParseError_Sections_Cannot_Be_Nested"), p0);

        /// <summary>
        /// Expected a "{0}" but found a "{1}".  Block statements must be enclosed in "{{" and "}}".  You cannot use single-statement control-flow statements in CSHTML pages. For example, the following is not allowed:
        /// 
        /// @if(isLoggedIn)
        ///     &lt;p&gt;Hello, @user&lt;/p&gt;
        /// 
        /// Instead, wrap the contents of the block in "{{}}":
        /// 
        /// @if(isLoggedIn) {{
        ///     &lt;p&gt;Hello, @user&lt;/p&gt;
        /// }}
        /// </summary>
        internal static string ParseError_SingleLine_ControlFlowStatements_Not_Allowed
        {
            get => GetString("ParseError_SingleLine_ControlFlowStatements_Not_Allowed");
        }

        /// <summary>
        /// Expected a "{0}" but found a "{1}".  Block statements must be enclosed in "{{" and "}}".  You cannot use single-statement control-flow statements in CSHTML pages. For example, the following is not allowed:
        /// 
        /// @if(isLoggedIn)
        ///     &lt;p&gt;Hello, @user&lt;/p&gt;
        /// 
        /// Instead, wrap the contents of the block in "{{}}":
        /// 
        /// @if(isLoggedIn) {{
        ///     &lt;p&gt;Hello, @user&lt;/p&gt;
        /// }}
        /// </summary>
        internal static string FormatParseError_SingleLine_ControlFlowStatements_Not_Allowed(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("ParseError_SingleLine_ControlFlowStatements_Not_Allowed"), p0, p1);

        /// <summary>
        /// "&lt;text&gt;" and "&lt;/text&gt;" tags cannot contain attributes.
        /// </summary>
        internal static string ParseError_TextTagCannotContainAttributes
        {
            get => GetString("ParseError_TextTagCannotContainAttributes");
        }

        /// <summary>
        /// "&lt;text&gt;" and "&lt;/text&gt;" tags cannot contain attributes.
        /// </summary>
        internal static string FormatParseError_TextTagCannotContainAttributes()
            => GetString("ParseError_TextTagCannotContainAttributes");

        /// <summary>
        /// "{0}" is not valid at the start of a code block.  Only identifiers, keywords, comments, "(" and "{{" are valid.
        /// </summary>
        internal static string ParseError_Unexpected_Character_At_Start_Of_CodeBlock
        {
            get => GetString("ParseError_Unexpected_Character_At_Start_Of_CodeBlock");
        }

        /// <summary>
        /// "{0}" is not valid at the start of a code block.  Only identifiers, keywords, comments, "(" and "{{" are valid.
        /// </summary>
        internal static string FormatParseError_Unexpected_Character_At_Start_Of_CodeBlock(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("ParseError_Unexpected_Character_At_Start_Of_CodeBlock"), p0);

        /// <summary>
        /// End-of-file was found after the "@" character.  "@" must be followed by a valid code block.  If you want to output an "@", escape it using the sequence: "@@"
        /// </summary>
        internal static string ParseError_Unexpected_EndOfFile_At_Start_Of_CodeBlock
        {
            get => GetString("ParseError_Unexpected_EndOfFile_At_Start_Of_CodeBlock");
        }

        /// <summary>
        /// End-of-file was found after the "@" character.  "@" must be followed by a valid code block.  If you want to output an "@", escape it using the sequence: "@@"
        /// </summary>
        internal static string FormatParseError_Unexpected_EndOfFile_At_Start_Of_CodeBlock()
            => GetString("ParseError_Unexpected_EndOfFile_At_Start_Of_CodeBlock");

        /// <summary>
        /// Unexpected "{{" after "@" character. Once inside the body of a code block (@if {{}}, @{{}}, etc.) you do not need to use "@{{" to switch to code.
        /// </summary>
        internal static string ParseError_Unexpected_Nested_CodeBlock
        {
            get => GetString("ParseError_Unexpected_Nested_CodeBlock");
        }

        /// <summary>
        /// Unexpected "{{" after "@" character. Once inside the body of a code block (@if {{}}, @{{}}, etc.) you do not need to use "@{{" to switch to code.
        /// </summary>
        internal static string FormatParseError_Unexpected_Nested_CodeBlock()
            => GetString("ParseError_Unexpected_Nested_CodeBlock");

        /// <summary>
        /// A space or line break was encountered after the "@" character.  Only valid identifiers, keywords, comments, "(" and "{{" are valid at the start of a code block and they must occur immediately following "@" with no space in between.
        /// </summary>
        internal static string ParseError_Unexpected_WhiteSpace_At_Start_Of_CodeBlock
        {
            get => GetString("ParseError_Unexpected_WhiteSpace_At_Start_Of_CodeBlock");
        }

        /// <summary>
        /// A space or line break was encountered after the "@" character.  Only valid identifiers, keywords, comments, "(" and "{{" are valid at the start of a code block and they must occur immediately following "@" with no space in between.
        /// </summary>
        internal static string FormatParseError_Unexpected_WhiteSpace_At_Start_Of_CodeBlock()
            => GetString("ParseError_Unexpected_WhiteSpace_At_Start_Of_CodeBlock");

        /// <summary>
        /// Encountered end tag "{0}" with no matching start tag.  Are your start/end tags properly balanced?
        /// </summary>
        internal static string ParseError_UnexpectedEndTag
        {
            get => GetString("ParseError_UnexpectedEndTag");
        }

        /// <summary>
        /// Encountered end tag "{0}" with no matching start tag.  Are your start/end tags properly balanced?
        /// </summary>
        internal static string FormatParseError_UnexpectedEndTag(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("ParseError_UnexpectedEndTag"), p0);

        /// <summary>
        /// End of file or an unexpected character was reached before the "{0}" tag could be parsed.  Elements inside markup blocks must be complete. They must either be self-closing ("&lt;br /&gt;") or have matching end tags ("&lt;p&gt;Hello&lt;/p&gt;").  If you intended to display a "&lt;" character, use the "&amp;lt;" HTML entity.
        /// </summary>
        internal static string ParseError_UnfinishedTag
        {
            get => GetString("ParseError_UnfinishedTag");
        }

        /// <summary>
        /// End of file or an unexpected character was reached before the "{0}" tag could be parsed.  Elements inside markup blocks must be complete. They must either be self-closing ("&lt;br /&gt;") or have matching end tags ("&lt;p&gt;Hello&lt;/p&gt;").  If you intended to display a "&lt;" character, use the "&amp;lt;" HTML entity.
        /// </summary>
        internal static string FormatParseError_UnfinishedTag(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("ParseError_UnfinishedTag"), p0);

        /// <summary>
        /// Unterminated string literal.  Strings that start with a quotation mark (") must be terminated before the end of the line.  However, strings that start with @ and a quotation mark (@") can span multiple lines.
        /// </summary>
        internal static string ParseError_Unterminated_String_Literal
        {
            get => GetString("ParseError_Unterminated_String_Literal");
        }

        /// <summary>
        /// Unterminated string literal.  Strings that start with a quotation mark (") must be terminated before the end of the line.  However, strings that start with @ and a quotation mark (@") can span multiple lines.
        /// </summary>
        internal static string FormatParseError_Unterminated_String_Literal()
            => GetString("ParseError_Unterminated_String_Literal");

        /// <summary>
        /// Parser was started with a null Context property.  The Context property must be set BEFORE calling any methods on the parser.
        /// </summary>
        internal static string Parser_Context_Not_Set
        {
            get => GetString("Parser_Context_Not_Set");
        }

        /// <summary>
        /// Parser was started with a null Context property.  The Context property must be set BEFORE calling any methods on the parser.
        /// </summary>
        internal static string FormatParser_Context_Not_Set()
            => GetString("Parser_Context_Not_Set");

        /// <summary>
        /// Cannot complete the tree, StartBlock must be called at least once.
        /// </summary>
        internal static string ParserContext_CannotCompleteTree_NoRootBlock
        {
            get => GetString("ParserContext_CannotCompleteTree_NoRootBlock");
        }

        /// <summary>
        /// Cannot complete the tree, StartBlock must be called at least once.
        /// </summary>
        internal static string FormatParserContext_CannotCompleteTree_NoRootBlock()
            => GetString("ParserContext_CannotCompleteTree_NoRootBlock");

        /// <summary>
        /// Cannot complete the tree, there are still open blocks.
        /// </summary>
        internal static string ParserContext_CannotCompleteTree_OutstandingBlocks
        {
            get => GetString("ParserContext_CannotCompleteTree_OutstandingBlocks");
        }

        /// <summary>
        /// Cannot complete the tree, there are still open blocks.
        /// </summary>
        internal static string FormatParserContext_CannotCompleteTree_OutstandingBlocks()
            => GetString("ParserContext_CannotCompleteTree_OutstandingBlocks");

        /// <summary>
        /// Cannot finish span, there is no current block. Call StartBlock at least once before finishing a span
        /// </summary>
        internal static string ParserContext_NoCurrentBlock
        {
            get => GetString("ParserContext_NoCurrentBlock");
        }

        /// <summary>
        /// Cannot finish span, there is no current block. Call StartBlock at least once before finishing a span
        /// </summary>
        internal static string FormatParserContext_NoCurrentBlock()
            => GetString("ParserContext_NoCurrentBlock");

        /// <summary>
        /// The '{0}' phase requires a '{1}' provided by the '{2}'.
        /// </summary>
        internal static string PhaseDependencyMissing
        {
            get => GetString("PhaseDependencyMissing");
        }

        /// <summary>
        /// The '{0}' phase requires a '{1}' provided by the '{2}'.
        /// </summary>
        internal static string FormatPhaseDependencyMissing(object p0, object p1, object p2)
            => string.Format(CultureInfo.CurrentCulture, GetString("PhaseDependencyMissing"), p0, p1, p2);

        /// <summary>
        /// The phase must be initialized by setting the '{0}' property.
        /// </summary>
        internal static string PhaseMustBeInitialized
        {
            get => GetString("PhaseMustBeInitialized");
        }

        /// <summary>
        /// The phase must be initialized by setting the '{0}' property.
        /// </summary>
        internal static string FormatPhaseMustBeInitialized(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("PhaseMustBeInitialized"), p0);

        /// <summary>
        /// Path must begin with a forward slash '/'.
        /// </summary>
        internal static string RazorProject_PathMustStartWithForwardSlash
        {
            get => GetString("RazorProject_PathMustStartWithForwardSlash");
        }

        /// <summary>
        /// Path must begin with a forward slash '/'.
        /// </summary>
        internal static string FormatRazorProject_PathMustStartWithForwardSlash()
            => GetString("RazorProject_PathMustStartWithForwardSlash");

        /// <summary>
        /// The item '{0}' could not be found.
        /// </summary>
        internal static string RazorTemplateEngine_ItemCouldNotBeFound
        {
            get => GetString("RazorTemplateEngine_ItemCouldNotBeFound");
        }

        /// <summary>
        /// The item '{0}' could not be found.
        /// </summary>
        internal static string FormatRazorTemplateEngine_ItemCouldNotBeFound(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("RazorTemplateEngine_ItemCouldNotBeFound"), p0);

        /// <summary>
        /// Remove Tag Helpers for use in the current document.
        /// </summary>
        internal static string RemoveTagHelperDirective_Description
        {
            get => GetString("RemoveTagHelperDirective_Description");
        }

        /// <summary>
        /// Remove Tag Helpers for use in the current document.
        /// </summary>
        internal static string FormatRemoveTagHelperDirective_Description()
            => GetString("RemoveTagHelperDirective_Description");

        /// <summary>
        /// Remove tag helpers from the specified type name and assembly name. Specify '*' for the type name to remove all tag helper types from the specified assembly.
        /// </summary>
        internal static string RemoveTagHelperDirective_StringToken_Description
        {
            get => GetString("RemoveTagHelperDirective_StringToken_Description");
        }

        /// <summary>
        /// Remove tag helpers from the specified type name and assembly name. Specify '*' for the type name to remove all tag helper types from the specified assembly.
        /// </summary>
        internal static string FormatRemoveTagHelperDirective_StringToken_Description()
            => GetString("RemoveTagHelperDirective_StringToken_Description");

        /// <summary>
        /// TypeName, AssemblyName
        /// </summary>
        internal static string RemoveTagHelperDirective_StringToken_Name
        {
            get => GetString("RemoveTagHelperDirective_StringToken_Name");
        }

        /// <summary>
        /// TypeName, AssemblyName
        /// </summary>
        internal static string FormatRemoveTagHelperDirective_StringToken_Name()
            => GetString("RemoveTagHelperDirective_StringToken_Name");

        /// <summary>
        /// The '{0}' requires a '{1}' delegate to be set.
        /// </summary>
        internal static string RenderingContextRequiresDelegate
        {
            get => GetString("RenderingContextRequiresDelegate");
        }

        /// <summary>
        /// The '{0}' requires a '{1}' delegate to be set.
        /// </summary>
        internal static string FormatRenderingContextRequiresDelegate(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("RenderingContextRequiresDelegate"), p0, p1);

        /// <summary>
        /// Attribute '{0}' on tag helper element '{1}' requires a value. Tag helper bound attributes of type '{2}' cannot be empty or contain only whitespace.
        /// </summary>
        internal static string RewriterError_EmptyTagHelperBoundAttribute
        {
            get => GetString("RewriterError_EmptyTagHelperBoundAttribute");
        }

        /// <summary>
        /// Attribute '{0}' on tag helper element '{1}' requires a value. Tag helper bound attributes of type '{2}' cannot be empty or contain only whitespace.
        /// </summary>
        internal static string FormatRewriterError_EmptyTagHelperBoundAttribute(object p0, object p1, object p2)
            => string.Format(CultureInfo.CurrentCulture, GetString("RewriterError_EmptyTagHelperBoundAttribute"), p0, p1, p2);

        /// <summary>
        /// Define a section to be rendered in the configured layout page.
        /// </summary>
        internal static string SectionDirective_Description
        {
            get => GetString("SectionDirective_Description");
        }

        /// <summary>
        /// Define a section to be rendered in the configured layout page.
        /// </summary>
        internal static string FormatSectionDirective_Description()
            => GetString("SectionDirective_Description");

        /// <summary>
        /// The name of the section.
        /// </summary>
        internal static string SectionDirective_NameToken_Description
        {
            get => GetString("SectionDirective_NameToken_Description");
        }

        /// <summary>
        /// The name of the section.
        /// </summary>
        internal static string FormatSectionDirective_NameToken_Description()
            => GetString("SectionDirective_NameToken_Description");

        /// <summary>
        /// SectionName
        /// </summary>
        internal static string SectionDirective_NameToken_Name
        {
            get => GetString("SectionDirective_NameToken_Name");
        }

        /// <summary>
        /// SectionName
        /// </summary>
        internal static string FormatSectionDirective_NameToken_Name()
            => GetString("SectionDirective_NameToken_Name");

        /// <summary>
        /// @section Header { ... }
        /// </summary>
        internal static string SectionExample
        {
            get => GetString("SectionExample");
        }

        /// <summary>
        /// @section Header { ... }
        /// </summary>
        internal static string FormatSectionExample()
            => GetString("SectionExample");

        /// <summary>
        /// &lt;&lt;unknown&gt;&gt;
        /// </summary>
        internal static string Token_Unknown
        {
            get => GetString("Token_Unknown");
        }

        /// <summary>
        /// &lt;&lt;unknown&gt;&gt;
        /// </summary>
        internal static string FormatToken_Unknown()
            => GetString("Token_Unknown");

        /// <summary>
        /// Invalid tag helper bound property '{1}' on tag helper '{0}'. Tag helpers cannot bind to HTML attributes with name '{2}' because the name contains a '{3}' character.
        /// </summary>
        internal static string TagHelper_InvalidBoundAttributeName
        {
            get => GetString("TagHelper_InvalidBoundAttributeName");
        }

        /// <summary>
        /// Invalid tag helper bound property '{1}' on tag helper '{0}'. Tag helpers cannot bind to HTML attributes with name '{2}' because the name contains a '{3}' character.
        /// </summary>
        internal static string FormatTagHelper_InvalidBoundAttributeName(object p0, object p1, object p2, object p3)
            => string.Format(CultureInfo.CurrentCulture, GetString("TagHelper_InvalidBoundAttributeName"), p0, p1, p2, p3);

        /// <summary>
        /// Invalid tag helper bound property '{1}' on tag helper '{0}'. Tag helpers cannot bind to HTML attributes with name '{2}' because the name starts with '{3}'.
        /// </summary>
        internal static string TagHelper_InvalidBoundAttributeNameStartsWith
        {
            get => GetString("TagHelper_InvalidBoundAttributeNameStartsWith");
        }

        /// <summary>
        /// Invalid tag helper bound property '{1}' on tag helper '{0}'. Tag helpers cannot bind to HTML attributes with name '{2}' because the name starts with '{3}'.
        /// </summary>
        internal static string FormatTagHelper_InvalidBoundAttributeNameStartsWith(object p0, object p1, object p2, object p3)
            => string.Format(CultureInfo.CurrentCulture, GetString("TagHelper_InvalidBoundAttributeNameStartsWith"), p0, p1, p2, p3);

        /// <summary>
        /// Invalid tag helper bound property '{1}' on tag helper '{0}'. Tag helpers cannot bind to HTML attributes with a null or empty name.
        /// </summary>
        internal static string TagHelper_InvalidBoundAttributeNullOrWhitespace
        {
            get => GetString("TagHelper_InvalidBoundAttributeNullOrWhitespace");
        }

        /// <summary>
        /// Invalid tag helper bound property '{1}' on tag helper '{0}'. Tag helpers cannot bind to HTML attributes with a null or empty name.
        /// </summary>
        internal static string FormatTagHelper_InvalidBoundAttributeNullOrWhitespace(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("TagHelper_InvalidBoundAttributeNullOrWhitespace"), p0, p1);

        /// <summary>
        /// Invalid tag helper bound property '{1}' on tag helper '{0}'. Tag helpers cannot bind to HTML attributes with prefix '{2}' because the prefix contains a '{3}' character.
        /// </summary>
        internal static string TagHelper_InvalidBoundAttributePrefix
        {
            get => GetString("TagHelper_InvalidBoundAttributePrefix");
        }

        /// <summary>
        /// Invalid tag helper bound property '{1}' on tag helper '{0}'. Tag helpers cannot bind to HTML attributes with prefix '{2}' because the prefix contains a '{3}' character.
        /// </summary>
        internal static string FormatTagHelper_InvalidBoundAttributePrefix(object p0, object p1, object p2, object p3)
            => string.Format(CultureInfo.CurrentCulture, GetString("TagHelper_InvalidBoundAttributePrefix"), p0, p1, p2, p3);

        /// <summary>
        /// Invalid tag helper bound property '{1}' on tag helper '{0}'. Tag helpers cannot bind to HTML attributes with prefix '{2}' because the prefix starts with '{3}'.
        /// </summary>
        internal static string TagHelper_InvalidBoundAttributePrefixStartsWith
        {
            get => GetString("TagHelper_InvalidBoundAttributePrefixStartsWith");
        }

        /// <summary>
        /// Invalid tag helper bound property '{1}' on tag helper '{0}'. Tag helpers cannot bind to HTML attributes with prefix '{2}' because the prefix starts with '{3}'.
        /// </summary>
        internal static string FormatTagHelper_InvalidBoundAttributePrefixStartsWith(object p0, object p1, object p2, object p3)
            => string.Format(CultureInfo.CurrentCulture, GetString("TagHelper_InvalidBoundAttributePrefixStartsWith"), p0, p1, p2, p3);

        /// <summary>
        /// Invalid restricted child '{1}' for tag helper '{0}'. Tag helpers cannot restrict child elements that contain a '{2}' character.
        /// </summary>
        internal static string TagHelper_InvalidRestrictedChild
        {
            get => GetString("TagHelper_InvalidRestrictedChild");
        }

        /// <summary>
        /// Invalid restricted child '{1}' for tag helper '{0}'. Tag helpers cannot restrict child elements that contain a '{2}' character.
        /// </summary>
        internal static string FormatTagHelper_InvalidRestrictedChild(object p0, object p1, object p2)
            => string.Format(CultureInfo.CurrentCulture, GetString("TagHelper_InvalidRestrictedChild"), p0, p1, p2);

        /// <summary>
        /// Invalid restricted child for tag helper '{0}'. Name cannot be null or whitespace.
        /// </summary>
        internal static string TagHelper_InvalidRestrictedChildNullOrWhitespace
        {
            get => GetString("TagHelper_InvalidRestrictedChildNullOrWhitespace");
        }

        /// <summary>
        /// Invalid restricted child for tag helper '{0}'. Name cannot be null or whitespace.
        /// </summary>
        internal static string FormatTagHelper_InvalidRestrictedChildNullOrWhitespace(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("TagHelper_InvalidRestrictedChildNullOrWhitespace"), p0);

        /// <summary>
        /// Tag helpers cannot target attribute name '{0}' because it contains a '{1}' character.
        /// </summary>
        internal static string TagHelper_InvalidTargetedAttributeName
        {
            get => GetString("TagHelper_InvalidTargetedAttributeName");
        }

        /// <summary>
        /// Tag helpers cannot target attribute name '{0}' because it contains a '{1}' character.
        /// </summary>
        internal static string FormatTagHelper_InvalidTargetedAttributeName(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("TagHelper_InvalidTargetedAttributeName"), p0, p1);

        /// <summary>
        /// Targeted attribute name cannot be null or whitespace.
        /// </summary>
        internal static string TagHelper_InvalidTargetedAttributeNameNullOrWhitespace
        {
            get => GetString("TagHelper_InvalidTargetedAttributeNameNullOrWhitespace");
        }

        /// <summary>
        /// Targeted attribute name cannot be null or whitespace.
        /// </summary>
        internal static string FormatTagHelper_InvalidTargetedAttributeNameNullOrWhitespace()
            => GetString("TagHelper_InvalidTargetedAttributeNameNullOrWhitespace");

        /// <summary>
        /// Tag helpers cannot target parent tag name '{0}' because it contains a '{1}' character.
        /// </summary>
        internal static string TagHelper_InvalidTargetedParentTagName
        {
            get => GetString("TagHelper_InvalidTargetedParentTagName");
        }

        /// <summary>
        /// Tag helpers cannot target parent tag name '{0}' because it contains a '{1}' character.
        /// </summary>
        internal static string FormatTagHelper_InvalidTargetedParentTagName(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("TagHelper_InvalidTargetedParentTagName"), p0, p1);

        /// <summary>
        /// Targeted parent tag name cannot be null or whitespace.
        /// </summary>
        internal static string TagHelper_InvalidTargetedParentTagNameNullOrWhitespace
        {
            get => GetString("TagHelper_InvalidTargetedParentTagNameNullOrWhitespace");
        }

        /// <summary>
        /// Targeted parent tag name cannot be null or whitespace.
        /// </summary>
        internal static string FormatTagHelper_InvalidTargetedParentTagNameNullOrWhitespace()
            => GetString("TagHelper_InvalidTargetedParentTagNameNullOrWhitespace");

        /// <summary>
        /// Tag helpers cannot target tag name '{0}' because it contains a '{1}' character.
        /// </summary>
        internal static string TagHelper_InvalidTargetedTagName
        {
            get => GetString("TagHelper_InvalidTargetedTagName");
        }

        /// <summary>
        /// Tag helpers cannot target tag name '{0}' because it contains a '{1}' character.
        /// </summary>
        internal static string FormatTagHelper_InvalidTargetedTagName(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("TagHelper_InvalidTargetedTagName"), p0, p1);

        /// <summary>
        /// Targeted tag name cannot be null or whitespace.
        /// </summary>
        internal static string TagHelper_InvalidTargetedTagNameNullOrWhitespace
        {
            get => GetString("TagHelper_InvalidTargetedTagNameNullOrWhitespace");
        }

        /// <summary>
        /// Targeted tag name cannot be null or whitespace.
        /// </summary>
        internal static string FormatTagHelper_InvalidTargetedTagNameNullOrWhitespace()
            => GetString("TagHelper_InvalidTargetedTagNameNullOrWhitespace");

        /// <summary>
        /// Tag helper directive assembly name cannot be null or empty.
        /// </summary>
        internal static string TagHelperAssemblyNameCannotBeEmptyOrNull
        {
            get => GetString("TagHelperAssemblyNameCannotBeEmptyOrNull");
        }

        /// <summary>
        /// Tag helper directive assembly name cannot be null or empty.
        /// </summary>
        internal static string FormatTagHelperAssemblyNameCannotBeEmptyOrNull()
            => GetString("TagHelperAssemblyNameCannotBeEmptyOrNull");

        /// <summary>
        /// The tag helper attribute '{0}' in element '{1}' is missing a key. The syntax is '&lt;{1} {0}{{ key }}="value"&gt;'.
        /// </summary>
        internal static string TagHelperBlockRewriter_IndexerAttributeNameMustIncludeKey
        {
            get => GetString("TagHelperBlockRewriter_IndexerAttributeNameMustIncludeKey");
        }

        /// <summary>
        /// The tag helper attribute '{0}' in element '{1}' is missing a key. The syntax is '&lt;{1} {0}{{ key }}="value"&gt;'.
        /// </summary>
        internal static string FormatTagHelperBlockRewriter_IndexerAttributeNameMustIncludeKey(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("TagHelperBlockRewriter_IndexerAttributeNameMustIncludeKey"), p0, p1);

        /// <summary>
        /// TagHelper attributes must be well-formed.
        /// </summary>
        internal static string TagHelperBlockRewriter_TagHelperAttributeListMustBeWellFormed
        {
            get => GetString("TagHelperBlockRewriter_TagHelperAttributeListMustBeWellFormed");
        }

        /// <summary>
        /// TagHelper attributes must be well-formed.
        /// </summary>
        internal static string FormatTagHelperBlockRewriter_TagHelperAttributeListMustBeWellFormed()
            => GetString("TagHelperBlockRewriter_TagHelperAttributeListMustBeWellFormed");

        /// <summary>
        /// The parent &lt;{0}&gt; tag helper does not allow non-tag content. Only child tag helper(s) targeting tag name(s) '{1}' are allowed.
        /// </summary>
        internal static string TagHelperParseTreeRewriter_CannotHaveNonTagContent
        {
            get => GetString("TagHelperParseTreeRewriter_CannotHaveNonTagContent");
        }

        /// <summary>
        /// The parent &lt;{0}&gt; tag helper does not allow non-tag content. Only child tag helper(s) targeting tag name(s) '{1}' are allowed.
        /// </summary>
        internal static string FormatTagHelperParseTreeRewriter_CannotHaveNonTagContent(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("TagHelperParseTreeRewriter_CannotHaveNonTagContent"), p0, p1);

        /// <summary>
        /// Found an end tag (&lt;/{0}&gt;) for tag helper '{1}' with tag structure that disallows an end tag ('{2}').
        /// </summary>
        internal static string TagHelperParseTreeRewriter_EndTagTagHelperMustNotHaveAnEndTag
        {
            get => GetString("TagHelperParseTreeRewriter_EndTagTagHelperMustNotHaveAnEndTag");
        }

        /// <summary>
        /// Found an end tag (&lt;/{0}&gt;) for tag helper '{1}' with tag structure that disallows an end tag ('{2}').
        /// </summary>
        internal static string FormatTagHelperParseTreeRewriter_EndTagTagHelperMustNotHaveAnEndTag(object p0, object p1, object p2)
            => string.Format(CultureInfo.CurrentCulture, GetString("TagHelperParseTreeRewriter_EndTagTagHelperMustNotHaveAnEndTag"), p0, p1, p2);

        /// <summary>
        /// Tag helpers '{0}' and '{1}' targeting element '{2}' must not expect different {3} values.
        /// </summary>
        internal static string TagHelperParseTreeRewriter_InconsistentTagStructure
        {
            get => GetString("TagHelperParseTreeRewriter_InconsistentTagStructure");
        }

        /// <summary>
        /// Tag helpers '{0}' and '{1}' targeting element '{2}' must not expect different {3} values.
        /// </summary>
        internal static string FormatTagHelperParseTreeRewriter_InconsistentTagStructure(object p0, object p1, object p2, object p3)
            => string.Format(CultureInfo.CurrentCulture, GetString("TagHelperParseTreeRewriter_InconsistentTagStructure"), p0, p1, p2, p3);

        /// <summary>
        /// The &lt;{0}&gt; tag is not allowed by parent &lt;{1}&gt; tag helper. Only child tags with name(s) '{2}' are allowed.
        /// </summary>
        internal static string TagHelperParseTreeRewriter_InvalidNestedTag
        {
            get => GetString("TagHelperParseTreeRewriter_InvalidNestedTag");
        }

        /// <summary>
        /// The &lt;{0}&gt; tag is not allowed by parent &lt;{1}&gt; tag helper. Only child tags with name(s) '{2}' are allowed.
        /// </summary>
        internal static string FormatTagHelperParseTreeRewriter_InvalidNestedTag(object p0, object p1, object p2)
            => string.Format(CultureInfo.CurrentCulture, GetString("TagHelperParseTreeRewriter_InvalidNestedTag"), p0, p1, p2);

        /// <summary>
        /// Specify a prefix that is required in an element name for it to be included in Tag Helper processing.
        /// </summary>
        internal static string TagHelperPrefixDirective_Description
        {
            get => GetString("TagHelperPrefixDirective_Description");
        }

        /// <summary>
        /// Specify a prefix that is required in an element name for it to be included in Tag Helper processing.
        /// </summary>
        internal static string FormatTagHelperPrefixDirective_Description()
            => GetString("TagHelperPrefixDirective_Description");

        /// <summary>
        /// The tag prefix to apply to tag helpers.
        /// </summary>
        internal static string TagHelperPrefixDirective_PrefixToken_Description
        {
            get => GetString("TagHelperPrefixDirective_PrefixToken_Description");
        }

        /// <summary>
        /// The tag prefix to apply to tag helpers.
        /// </summary>
        internal static string FormatTagHelperPrefixDirective_PrefixToken_Description()
            => GetString("TagHelperPrefixDirective_PrefixToken_Description");

        /// <summary>
        /// Prefix
        /// </summary>
        internal static string TagHelperPrefixDirective_PrefixToken_Name
        {
            get => GetString("TagHelperPrefixDirective_PrefixToken_Name");
        }

        /// <summary>
        /// Prefix
        /// </summary>
        internal static string FormatTagHelperPrefixDirective_PrefixToken_Name()
            => GetString("TagHelperPrefixDirective_PrefixToken_Name");

        /// <summary>
        /// Tag Helper '{0}'s attributes must have names.
        /// </summary>
        internal static string TagHelpers_AttributesMustHaveAName
        {
            get => GetString("TagHelpers_AttributesMustHaveAName");
        }

        /// <summary>
        /// Tag Helper '{0}'s attributes must have names.
        /// </summary>
        internal static string FormatTagHelpers_AttributesMustHaveAName(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("TagHelpers_AttributesMustHaveAName"), p0);

        /// <summary>
        /// The tag helper '{0}' must not have C# in the element's attribute declaration area.
        /// </summary>
        internal static string TagHelpers_CannotHaveCSharpInTagDeclaration
        {
            get => GetString("TagHelpers_CannotHaveCSharpInTagDeclaration");
        }

        /// <summary>
        /// The tag helper '{0}' must not have C# in the element's attribute declaration area.
        /// </summary>
        internal static string FormatTagHelpers_CannotHaveCSharpInTagDeclaration(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("TagHelpers_CannotHaveCSharpInTagDeclaration"), p0);

        /// <summary>
        /// Code blocks (e.g. @{{var variable = 23;}}) must not appear in non-string tag helper attribute values.
        ///  Already in an expression (code) context. If necessary an explicit expression (e.g. @(@readonly)) may be used.
        /// </summary>
        internal static string TagHelpers_CodeBlocks_NotSupported_InAttributes
        {
            get => GetString("TagHelpers_CodeBlocks_NotSupported_InAttributes");
        }

        /// <summary>
        /// Code blocks (e.g. @{{var variable = 23;}}) must not appear in non-string tag helper attribute values.
        ///  Already in an expression (code) context. If necessary an explicit expression (e.g. @(@readonly)) may be used.
        /// </summary>
        internal static string FormatTagHelpers_CodeBlocks_NotSupported_InAttributes()
            => GetString("TagHelpers_CodeBlocks_NotSupported_InAttributes");

        /// <summary>
        /// Inline markup blocks (e.g. @&lt;p&gt;content&lt;/p&gt;) must not appear in non-string tag helper attribute values.
        ///  Expected a '{0}' attribute value, not a string.
        /// </summary>
        internal static string TagHelpers_InlineMarkupBlocks_NotSupported_InAttributes
        {
            get => GetString("TagHelpers_InlineMarkupBlocks_NotSupported_InAttributes");
        }

        /// <summary>
        /// Inline markup blocks (e.g. @&lt;p&gt;content&lt;/p&gt;) must not appear in non-string tag helper attribute values.
        ///  Expected a '{0}' attribute value, not a string.
        /// </summary>
        internal static string FormatTagHelpers_InlineMarkupBlocks_NotSupported_InAttributes(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("TagHelpers_InlineMarkupBlocks_NotSupported_InAttributes"), p0);

        /// <summary>
        /// Found a malformed '{0}' tag helper. Tag helpers must have a start and end tag or be self closing.
        /// </summary>
        internal static string TagHelpersParseTreeRewriter_FoundMalformedTagHelper
        {
            get => GetString("TagHelpersParseTreeRewriter_FoundMalformedTagHelper");
        }

        /// <summary>
        /// Found a malformed '{0}' tag helper. Tag helpers must have a start and end tag or be self closing.
        /// </summary>
        internal static string FormatTagHelpersParseTreeRewriter_FoundMalformedTagHelper(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("TagHelpersParseTreeRewriter_FoundMalformedTagHelper"), p0);

        /// <summary>
        /// Missing close angle for tag helper '{0}'.
        /// </summary>
        internal static string TagHelpersParseTreeRewriter_MissingCloseAngle
        {
            get => GetString("TagHelpersParseTreeRewriter_MissingCloseAngle");
        }

        /// <summary>
        /// Missing close angle for tag helper '{0}'.
        /// </summary>
        internal static string FormatTagHelpersParseTreeRewriter_MissingCloseAngle(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("TagHelpersParseTreeRewriter_MissingCloseAngle"), p0);

        /// <summary>
        /// Unreachable code. This can happen when a new {0} is introduced.
        /// </summary>
        internal static string UnexpectedDirectiveKind
        {
            get => GetString("UnexpectedDirectiveKind");
        }

        /// <summary>
        /// Unreachable code. This can happen when a new {0} is introduced.
        /// </summary>
        internal static string FormatUnexpectedDirectiveKind(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("UnexpectedDirectiveKind"), p0);

        /// <summary>
        /// Unexpected literal following the '{0}' directive. Expected '{1}'.
        /// </summary>
        internal static string UnexpectedDirectiveLiteral
        {
            get => GetString("UnexpectedDirectiveLiteral");
        }

        /// <summary>
        /// Unexpected literal following the '{0}' directive. Expected '{1}'.
        /// </summary>
        internal static string FormatUnexpectedDirectiveLiteral(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("UnexpectedDirectiveLiteral"), p0, p1);

        /// <summary>
        /// Unexpected end of file following the '{0}' directive. Expected '{1}'.
        /// </summary>
        internal static string UnexpectedEOFAfterDirective
        {
            get => GetString("UnexpectedEOFAfterDirective");
        }

        /// <summary>
        /// Unexpected end of file following the '{0}' directive. Expected '{1}'.
        /// </summary>
        internal static string FormatUnexpectedEOFAfterDirective(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("UnexpectedEOFAfterDirective"), p0, p1);

        /// <summary>
        /// The hash algorithm '{0}' is not supported for checksum generation. Supported algorithms are: '{1}'. Set '{2}' to '{3}' to suppress automatic checksum generation.
        /// </summary>
        internal static string UnsupportedChecksumAlgorithm
        {
            get => GetString("UnsupportedChecksumAlgorithm");
        }

        /// <summary>
        /// The hash algorithm '{0}' is not supported for checksum generation. Supported algorithms are: '{1}'. Set '{2}' to '{3}' to suppress automatic checksum generation.
        /// </summary>
        internal static string FormatUnsupportedChecksumAlgorithm(object p0, object p1, object p2, object p3)
            => string.Format(CultureInfo.CurrentCulture, GetString("UnsupportedChecksumAlgorithm"), p0, p1, p2, p3);

        /// <summary>
        /// The '{0}.{1}' property must not be null.
        /// </summary>
        internal static string PropertyMustNotBeNull
        {
            get => GetString("PropertyMustNotBeNull");
        }

        /// <summary>
        /// The '{0}.{1}' property must not be null.
        /// </summary>
        internal static string FormatPropertyMustNotBeNull(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("PropertyMustNotBeNull"), p0, p1);

        /// <summary>
        /// The '{0}' is missing feature '{1}'.
        /// </summary>
        internal static string RazorProjectEngineMissingFeatureDependency
        {
            get => GetString("RazorProjectEngineMissingFeatureDependency");
        }

        /// <summary>
        /// The '{0}' is missing feature '{1}'.
        /// </summary>
        internal static string FormatRazorProjectEngineMissingFeatureDependency(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("RazorProjectEngineMissingFeatureDependency"), p0, p1);

        /// <summary>
        /// The Razor language version '{0}' is unrecognized or not supported by this version of Razor.
        /// </summary>
        internal static string RazorLanguageVersion_InvalidVersion
        {
            get => GetString("RazorLanguageVersion_InvalidVersion");
        }

        /// <summary>
        /// The Razor language version '{0}' is unrecognized or not supported by this version of Razor.
        /// </summary>
        internal static string FormatRazorLanguageVersion_InvalidVersion(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("RazorLanguageVersion_InvalidVersion"), p0);

        /// <summary>
        /// File path '{0}' does not belong to the directory '{1}'.
        /// </summary>
        internal static string VirtualFileSystem_FileDoesNotBelongToDirectory
        {
            get => GetString("VirtualFileSystem_FileDoesNotBelongToDirectory");
        }

        /// <summary>
        /// File path '{0}' does not belong to the directory '{1}'.
        /// </summary>
        internal static string FormatVirtualFileSystem_FileDoesNotBelongToDirectory(object p0, object p1)
            => string.Format(CultureInfo.CurrentCulture, GetString("VirtualFileSystem_FileDoesNotBelongToDirectory"), p0, p1);

        /// <summary>
        /// The file path '{0}' is invalid. File path is the root relative path of the file starting with '/' and should not contain any '\' characters.
        /// </summary>
        internal static string VirtualFileSystem_InvalidRelativePath
        {
            get => GetString("VirtualFileSystem_InvalidRelativePath");
        }

        /// <summary>
        /// The file path '{0}' is invalid. File path is the root relative path of the file starting with '/' and should not contain any '\' characters.
        /// </summary>
        internal static string FormatVirtualFileSystem_InvalidRelativePath(object p0)
            => string.Format(CultureInfo.CurrentCulture, GetString("VirtualFileSystem_InvalidRelativePath"), p0);

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
