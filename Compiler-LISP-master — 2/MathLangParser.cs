// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2018-01-18 00:23:58

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;
using Map = System.Collections.IDictionary;
using HashMap = System.Collections.Generic.Dictionary<object, object>;

using Antlr.Runtime.Tree;
using RewriteRuleITokenStream = Antlr.Runtime.Tree.RewriteRuleTokenStream;

namespace  MathLang 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:50:56")]
[System.CLSCompliant(false)]
public partial class MathLangParser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "NULL", "NIL", "QUOTE", "CAR", "CDR", "CONS", "EQUAL", "DEFUN", "ASSIGN", "IF", "BLOCK", "PROGRAM", "WS", "SL_COMMENT", "ML_COMMENT", "ATOM", "WORD", "VARIABLE", "ADD", "SUB", "MUL", "DIV", "GE", "LE", "NEQUALS", "GT", "LT", "EQUALS", "DOT", "'('", "')'", "'()'", "'\"'"
	};
	public const int EOF=-1;
	public const int T__33=33;
	public const int T__34=34;
	public const int T__35=35;
	public const int T__36=36;
	public const int NULL=4;
	public const int NIL=5;
	public const int QUOTE=6;
	public const int CAR=7;
	public const int CDR=8;
	public const int CONS=9;
	public const int EQUAL=10;
	public const int DEFUN=11;
	public const int ASSIGN=12;
	public const int IF=13;
	public const int BLOCK=14;
	public const int PROGRAM=15;
	public const int WS=16;
	public const int SL_COMMENT=17;
	public const int ML_COMMENT=18;
	public const int ATOM=19;
	public const int WORD=20;
	public const int VARIABLE=21;
	public const int ADD=22;
	public const int SUB=23;
	public const int MUL=24;
	public const int DIV=25;
	public const int GE=26;
	public const int LE=27;
	public const int NEQUALS=28;
	public const int GT=29;
	public const int LT=30;
	public const int EQUALS=31;
	public const int DOT=32;

	// delegates
	// delegators

	#if ANTLR_DEBUG
		private static readonly bool[] decisionCanBacktrack =
			new bool[]
			{
				false, // invalid decision
				false, false, false, false, false, false, false, false, false, false, 
				true, false, false, true, false, false, false, false, false, true, false, 
				, false
			};
	#else
		private static readonly bool[] decisionCanBacktrack = new bool[0];
	#endif
	public MathLangParser( ITokenStream input )
		: this( input, new RecognizerSharedState() )
	{
	}
	public MathLangParser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{
		this.state.ruleMemo = new System.Collections.Generic.Dictionary<int, int>[79+1];

		ITreeAdaptor treeAdaptor = null;
		CreateTreeAdaptor(ref treeAdaptor);
		TreeAdaptor = treeAdaptor ?? new CommonTreeAdaptor();

		OnCreated();
	}
		
	// Implement this function in your helper file to use a custom tree adaptor
	partial void CreateTreeAdaptor(ref ITreeAdaptor adaptor);

	private ITreeAdaptor adaptor;

	public ITreeAdaptor TreeAdaptor
	{
		get
		{
			return adaptor;
		}
		set
		{
			this.adaptor = value;
		}
	}

	public override string[] TokenNames { get { return MathLangParser.tokenNames; } }
	public override string GrammarFileName { get { return "MathLang.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	#region Rules
	public class group_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_group();
	partial void Leave_group();

	// $ANTLR start "group"
	// MathLang.g:71:1: group : ( '(' term ')' | ATOM | nil | nil2 | methodExe );
	[GrammarRule("group")]
	private MathLangParser.group_return group()
	{
		Enter_group();
		EnterRule("group", 1);
		TraceIn("group", 1);
		MathLangParser.group_return retval = new MathLangParser.group_return();
		retval.Start = (IToken)input.LT(1);
		int group_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal1=null;
		IToken char_literal3=null;
		IToken ATOM4=null;
		MathLangParser.term_return term2 = default(MathLangParser.term_return);
		MathLangParser.nil_return nil5 = default(MathLangParser.nil_return);
		MathLangParser.nil2_return nil26 = default(MathLangParser.nil2_return);
		MathLangParser.methodExe_return methodExe7 = default(MathLangParser.methodExe_return);

		object char_literal1_tree=null;
		object char_literal3_tree=null;
		object ATOM4_tree=null;

		try { DebugEnterRule(GrammarFileName, "group");
		DebugLocation(71, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 1)) { return retval; }
			// MathLang.g:71:6: ( '(' term ')' | ATOM | nil | nil2 | methodExe )
			int alt1=5;
			try { DebugEnterDecision(1, decisionCanBacktrack[1]);
			switch (input.LA(1))
			{
			case 33:
				{
				int LA1_1 = input.LA(2);

				if ((LA1_1==WORD))
				{
					int LA1_5 = input.LA(3);

					if ((LA1_5==33))
					{
						alt1=5;
					}
					else if ((LA1_5==34))
					{
						alt1=1;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 1, 5, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}
				else if ((LA1_1==NIL||LA1_1==ATOM||(LA1_1>=ADD && LA1_1<=EQUALS)||LA1_1==33||LA1_1==35))
				{
					alt1=1;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 1, 1, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			case ATOM:
				{
				alt1=2;
				}
				break;
			case NIL:
				{
				alt1=3;
				}
				break;
			case 35:
				{
				alt1=4;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 1, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(1); }
			switch (alt1)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:72:3: '(' term ')'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(72, 6);
				char_literal1=(IToken)Match(input,33,Follow._33_in_group615); if (state.failed) return retval;
				DebugLocation(72, 8);
				PushFollow(Follow._term_in_group618);
				term2=term();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, term2.Tree);
				DebugLocation(72, 16);
				char_literal3=(IToken)Match(input,34,Follow._34_in_group620); if (state.failed) return retval;

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:73:5: ATOM
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(73, 5);
				ATOM4=(IToken)Match(input,ATOM,Follow._ATOM_in_group627); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				ATOM4_tree = (object)adaptor.Create(ATOM4);
				adaptor.AddChild(root_0, ATOM4_tree);
				}

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:74:5: nil
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(74, 5);
				PushFollow(Follow._nil_in_group633);
				nil5=nil();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, nil5.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:75:5: nil2
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(75, 5);
				PushFollow(Follow._nil2_in_group639);
				nil26=nil2();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, nil26.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:76:5: methodExe
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(76, 5);
				PushFollow(Follow._methodExe_in_group645);
				methodExe7=methodExe();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodExe7.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("group", 1);
			LeaveRule("group", 1);
			Leave_group();
			if (state.backtracking > 0) { Memoize(input, 1, group_StartIndex); }
		}
		DebugLocation(77, 0);
		} finally { DebugExitRule(GrammarFileName, "group"); }
		return retval;

	}
	// $ANTLR end "group"

	public class mult_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_mult();
	partial void Leave_mult();

	// $ANTLR start "mult"
	// MathLang.g:79:1: mult : ( ( MUL | DIV ) ( group | WORD ) )? ( group | WORD ) ;
	[GrammarRule("mult")]
	private MathLangParser.mult_return mult()
	{
		Enter_mult();
		EnterRule("mult", 2);
		TraceIn("mult", 2);
		MathLangParser.mult_return retval = new MathLangParser.mult_return();
		retval.Start = (IToken)input.LT(1);
		int mult_StartIndex = input.Index;
		object root_0 = null;

		IToken set8=null;
		IToken WORD10=null;
		IToken WORD12=null;
		MathLangParser.group_return group9 = default(MathLangParser.group_return);
		MathLangParser.group_return group11 = default(MathLangParser.group_return);

		object set8_tree=null;
		object WORD10_tree=null;
		object WORD12_tree=null;

		try { DebugEnterRule(GrammarFileName, "mult");
		DebugLocation(79, 56);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 2)) { return retval; }
			// MathLang.g:79:5: ( ( ( MUL | DIV ) ( group | WORD ) )? ( group | WORD ) )
			DebugEnterAlt(1);
			// MathLang.g:79:7: ( ( MUL | DIV ) ( group | WORD ) )? ( group | WORD )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(79, 7);
			// MathLang.g:79:7: ( ( MUL | DIV ) ( group | WORD ) )?
			int alt3=2;
			try { DebugEnterSubRule(3);
			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
			int LA3_0 = input.LA(1);

			if (((LA3_0>=MUL && LA3_0<=DIV)))
			{
				alt3=1;
			}
			} finally { DebugExitDecision(3); }
			switch (alt3)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:79:8: ( MUL | DIV ) ( group | WORD )
				{
				DebugLocation(79, 8);
				set8=(IToken)input.LT(1);
				set8=(IToken)input.LT(1);
				if ((input.LA(1)>=MUL && input.LA(1)<=DIV))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set8), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(79, 23);
				// MathLang.g:79:23: ( group | WORD )
				int alt2=2;
				try { DebugEnterSubRule(2);
				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
				int LA2_0 = input.LA(1);

				if ((LA2_0==NIL||LA2_0==ATOM||LA2_0==33||LA2_0==35))
				{
					alt2=1;
				}
				else if ((LA2_0==WORD))
				{
					alt2=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 2, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				} finally { DebugExitDecision(2); }
				switch (alt2)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:79:24: group
					{
					DebugLocation(79, 24);
					PushFollow(Follow._group_in_mult666);
					group9=group();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group9.Tree);

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// MathLang.g:79:32: WORD
					{
					DebugLocation(79, 32);
					WORD10=(IToken)Match(input,WORD,Follow._WORD_in_mult670); if (state.failed) return retval;
					if ( state.backtracking==0 ) {
					WORD10_tree = (object)adaptor.Create(WORD10);
					adaptor.AddChild(root_0, WORD10_tree);
					}

					}
					break;

				}
				} finally { DebugExitSubRule(2); }


				}
				break;

			}
			} finally { DebugExitSubRule(3); }

			DebugLocation(79, 40);
			// MathLang.g:79:40: ( group | WORD )
			int alt4=2;
			try { DebugEnterSubRule(4);
			try { DebugEnterDecision(4, decisionCanBacktrack[4]);
			int LA4_0 = input.LA(1);

			if ((LA4_0==NIL||LA4_0==ATOM||LA4_0==33||LA4_0==35))
			{
				alt4=1;
			}
			else if ((LA4_0==WORD))
			{
				alt4=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 4, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(4); }
			switch (alt4)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:79:41: group
				{
				DebugLocation(79, 41);
				PushFollow(Follow._group_in_mult676);
				group11=group();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group11.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:79:49: WORD
				{
				DebugLocation(79, 49);
				WORD12=(IToken)Match(input,WORD,Follow._WORD_in_mult680); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				WORD12_tree = (object)adaptor.Create(WORD12);
				adaptor.AddChild(root_0, WORD12_tree);
				}

				}
				break;

			}
			} finally { DebugExitSubRule(4); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("mult", 2);
			LeaveRule("mult", 2);
			Leave_mult();
			if (state.backtracking > 0) { Memoize(input, 2, mult_StartIndex); }
		}
		DebugLocation(79, 56);
		} finally { DebugExitRule(GrammarFileName, "mult"); }
		return retval;

	}
	// $ANTLR end "mult"

	public class add_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_add();
	partial void Leave_add();

	// $ANTLR start "add"
	// MathLang.g:80:1: add : ( ( ADD | SUB ) mult )? mult ;
	[GrammarRule("add")]
	private MathLangParser.add_return add()
	{
		Enter_add();
		EnterRule("add", 3);
		TraceIn("add", 3);
		MathLangParser.add_return retval = new MathLangParser.add_return();
		retval.Start = (IToken)input.LT(1);
		int add_StartIndex = input.Index;
		object root_0 = null;

		IToken set13=null;
		MathLangParser.mult_return mult14 = default(MathLangParser.mult_return);
		MathLangParser.mult_return mult15 = default(MathLangParser.mult_return);

		object set13_tree=null;

		try { DebugEnterRule(GrammarFileName, "add");
		DebugLocation(80, 38);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 3)) { return retval; }
			// MathLang.g:80:4: ( ( ( ADD | SUB ) mult )? mult )
			DebugEnterAlt(1);
			// MathLang.g:80:7: ( ( ADD | SUB ) mult )? mult
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(80, 7);
			// MathLang.g:80:7: ( ( ADD | SUB ) mult )?
			int alt5=2;
			try { DebugEnterSubRule(5);
			try { DebugEnterDecision(5, decisionCanBacktrack[5]);
			int LA5_0 = input.LA(1);

			if (((LA5_0>=ADD && LA5_0<=SUB)))
			{
				alt5=1;
			}
			} finally { DebugExitDecision(5); }
			switch (alt5)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:80:8: ( ADD | SUB ) mult
				{
				DebugLocation(80, 8);
				set13=(IToken)input.LT(1);
				set13=(IToken)input.LT(1);
				if ((input.LA(1)>=ADD && input.LA(1)<=SUB))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set13), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(80, 23);
				PushFollow(Follow._mult_in_add703);
				mult14=mult();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult14.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(5); }

			DebugLocation(80, 30);
			PushFollow(Follow._mult_in_add707);
			mult15=mult();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, mult15.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("add", 3);
			LeaveRule("add", 3);
			Leave_add();
			if (state.backtracking > 0) { Memoize(input, 3, add_StartIndex); }
		}
		DebugLocation(80, 38);
		} finally { DebugExitRule(GrammarFileName, "add"); }
		return retval;

	}
	// $ANTLR end "add"

	public class compare_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_compare();
	partial void Leave_compare();

	// $ANTLR start "compare"
	// MathLang.g:81:1: compare : ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )? add ;
	[GrammarRule("compare")]
	private MathLangParser.compare_return compare()
	{
		Enter_compare();
		EnterRule("compare", 4);
		TraceIn("compare", 4);
		MathLangParser.compare_return retval = new MathLangParser.compare_return();
		retval.Start = (IToken)input.LT(1);
		int compare_StartIndex = input.Index;
		object root_0 = null;

		IToken set16=null;
		MathLangParser.add_return add17 = default(MathLangParser.add_return);
		MathLangParser.add_return add18 = default(MathLangParser.add_return);

		object set16_tree=null;

		try { DebugEnterRule(GrammarFileName, "compare");
		DebugLocation(81, 64);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 4)) { return retval; }
			// MathLang.g:81:8: ( ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )? add )
			DebugEnterAlt(1);
			// MathLang.g:81:12: ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )? add
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(81, 12);
			// MathLang.g:81:12: ( ( GE | LE | NEQUALS | EQUALS | GT | LT ) add )?
			int alt6=2;
			try { DebugEnterSubRule(6);
			try { DebugEnterDecision(6, decisionCanBacktrack[6]);
			int LA6_0 = input.LA(1);

			if (((LA6_0>=GE && LA6_0<=EQUALS)))
			{
				alt6=1;
			}
			} finally { DebugExitDecision(6); }
			switch (alt6)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:81:13: ( GE | LE | NEQUALS | EQUALS | GT | LT ) add
				{
				DebugLocation(81, 13);
				set16=(IToken)input.LT(1);
				set16=(IToken)input.LT(1);
				if ((input.LA(1)>=GE && input.LA(1)<=EQUALS))
				{
					input.Consume();
					if ( state.backtracking == 0 ) root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set16), root_0);
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}

				DebugLocation(81, 54);
				PushFollow(Follow._add_in_compare747);
				add17=add();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add17.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(6); }

			DebugLocation(81, 60);
			PushFollow(Follow._add_in_compare751);
			add18=add();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, add18.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("compare", 4);
			LeaveRule("compare", 4);
			Leave_compare();
			if (state.backtracking > 0) { Memoize(input, 4, compare_StartIndex); }
		}
		DebugLocation(81, 64);
		} finally { DebugExitRule(GrammarFileName, "compare"); }
		return retval;

	}
	// $ANTLR end "compare"

	public class term_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_term();
	partial void Leave_term();

	// $ANTLR start "term"
	// MathLang.g:82:1: term : compare ;
	[GrammarRule("term")]
	private MathLangParser.term_return term()
	{
		Enter_term();
		EnterRule("term", 5);
		TraceIn("term", 5);
		MathLangParser.term_return retval = new MathLangParser.term_return();
		retval.Start = (IToken)input.LT(1);
		int term_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.compare_return compare19 = default(MathLangParser.compare_return);


		try { DebugEnterRule(GrammarFileName, "term");
		DebugLocation(82, 15);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 5)) { return retval; }
			// MathLang.g:82:5: ( compare )
			DebugEnterAlt(1);
			// MathLang.g:82:7: compare
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(82, 7);
			PushFollow(Follow._compare_in_term759);
			compare19=compare();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare19.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("term", 5);
			LeaveRule("term", 5);
			Leave_term();
			if (state.backtracking > 0) { Memoize(input, 5, term_StartIndex); }
		}
		DebugLocation(82, 15);
		} finally { DebugExitRule(GrammarFileName, "term"); }
		return retval;

	}
	// $ANTLR end "term"

	public class dotPair_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_dotPair();
	partial void Leave_dotPair();

	// $ANTLR start "dotPair"
	// MathLang.g:84:1: dotPair : '(' ( ATOM | dotPair | NIL ) DOT ( ATOM | dotPair | NIL ) ')' ;
	[GrammarRule("dotPair")]
	private MathLangParser.dotPair_return dotPair()
	{
		Enter_dotPair();
		EnterRule("dotPair", 6);
		TraceIn("dotPair", 6);
		MathLangParser.dotPair_return retval = new MathLangParser.dotPair_return();
		retval.Start = (IToken)input.LT(1);
		int dotPair_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal20=null;
		IToken ATOM21=null;
		IToken NIL23=null;
		IToken DOT24=null;
		IToken ATOM25=null;
		IToken NIL27=null;
		IToken char_literal28=null;
		MathLangParser.dotPair_return dotPair22 = default(MathLangParser.dotPair_return);
		MathLangParser.dotPair_return dotPair26 = default(MathLangParser.dotPair_return);

		object char_literal20_tree=null;
		object ATOM21_tree=null;
		object NIL23_tree=null;
		object DOT24_tree=null;
		object ATOM25_tree=null;
		object NIL27_tree=null;
		object char_literal28_tree=null;

		try { DebugEnterRule(GrammarFileName, "dotPair");
		DebugLocation(84, 73);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 6)) { return retval; }
			// MathLang.g:84:9: ( '(' ( ATOM | dotPair | NIL ) DOT ( ATOM | dotPair | NIL ) ')' )
			DebugEnterAlt(1);
			// MathLang.g:84:11: '(' ( ATOM | dotPair | NIL ) DOT ( ATOM | dotPair | NIL ) ')'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(84, 14);
			char_literal20=(IToken)Match(input,33,Follow._33_in_dotPair769); if (state.failed) return retval;
			DebugLocation(84, 16);
			// MathLang.g:84:16: ( ATOM | dotPair | NIL )
			int alt7=3;
			try { DebugEnterSubRule(7);
			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
			switch (input.LA(1))
			{
			case ATOM:
				{
				alt7=1;
				}
				break;
			case 33:
				{
				alt7=2;
				}
				break;
			case NIL:
				{
				alt7=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 7, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(7); }
			switch (alt7)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:84:17: ATOM
				{
				DebugLocation(84, 17);
				ATOM21=(IToken)Match(input,ATOM,Follow._ATOM_in_dotPair773); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				ATOM21_tree = (object)adaptor.Create(ATOM21);
				adaptor.AddChild(root_0, ATOM21_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:84:24: dotPair
				{
				DebugLocation(84, 24);
				PushFollow(Follow._dotPair_in_dotPair777);
				dotPair22=dotPair();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dotPair22.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:84:34: NIL
				{
				DebugLocation(84, 34);
				NIL23=(IToken)Match(input,NIL,Follow._NIL_in_dotPair781); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				NIL23_tree = (object)adaptor.Create(NIL23);
				adaptor.AddChild(root_0, NIL23_tree);
				}

				}
				break;

			}
			} finally { DebugExitSubRule(7); }

			DebugLocation(84, 42);
			DOT24=(IToken)Match(input,DOT,Follow._DOT_in_dotPair784); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			DOT24_tree = (object)adaptor.Create(DOT24);
			root_0 = (object)adaptor.BecomeRoot(DOT24_tree, root_0);
			}
			DebugLocation(84, 44);
			// MathLang.g:84:44: ( ATOM | dotPair | NIL )
			int alt8=3;
			try { DebugEnterSubRule(8);
			try { DebugEnterDecision(8, decisionCanBacktrack[8]);
			switch (input.LA(1))
			{
			case ATOM:
				{
				alt8=1;
				}
				break;
			case 33:
				{
				alt8=2;
				}
				break;
			case NIL:
				{
				alt8=3;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 8, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(8); }
			switch (alt8)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:84:45: ATOM
				{
				DebugLocation(84, 45);
				ATOM25=(IToken)Match(input,ATOM,Follow._ATOM_in_dotPair788); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				ATOM25_tree = (object)adaptor.Create(ATOM25);
				adaptor.AddChild(root_0, ATOM25_tree);
				}

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:84:52: dotPair
				{
				DebugLocation(84, 52);
				PushFollow(Follow._dotPair_in_dotPair792);
				dotPair26=dotPair();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dotPair26.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:84:62: NIL
				{
				DebugLocation(84, 62);
				NIL27=(IToken)Match(input,NIL,Follow._NIL_in_dotPair796); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				NIL27_tree = (object)adaptor.Create(NIL27);
				adaptor.AddChild(root_0, NIL27_tree);
				}

				}
				break;

			}
			} finally { DebugExitSubRule(8); }

			DebugLocation(84, 70);
			char_literal28=(IToken)Match(input,34,Follow._34_in_dotPair799); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("dotPair", 6);
			LeaveRule("dotPair", 6);
			Leave_dotPair();
			if (state.backtracking > 0) { Memoize(input, 6, dotPair_StartIndex); }
		}
		DebugLocation(84, 73);
		} finally { DebugExitRule(GrammarFileName, "dotPair"); }
		return retval;

	}
	// $ANTLR end "dotPair"

	public class nil_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_nil();
	partial void Leave_nil();

	// $ANTLR start "nil"
	// MathLang.g:86:1: nil : NIL ;
	[GrammarRule("nil")]
	private MathLangParser.nil_return nil()
	{
		Enter_nil();
		EnterRule("nil", 7);
		TraceIn("nil", 7);
		MathLangParser.nil_return retval = new MathLangParser.nil_return();
		retval.Start = (IToken)input.LT(1);
		int nil_StartIndex = input.Index;
		object root_0 = null;

		IToken NIL29=null;

		object NIL29_tree=null;

		try { DebugEnterRule(GrammarFileName, "nil");
		DebugLocation(86, 8);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 7)) { return retval; }
			// MathLang.g:86:4: ( NIL )
			DebugEnterAlt(1);
			// MathLang.g:86:6: NIL
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(86, 6);
			NIL29=(IToken)Match(input,NIL,Follow._NIL_in_nil845); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			NIL29_tree = (object)adaptor.Create(NIL29);
			adaptor.AddChild(root_0, NIL29_tree);
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("nil", 7);
			LeaveRule("nil", 7);
			Leave_nil();
			if (state.backtracking > 0) { Memoize(input, 7, nil_StartIndex); }
		}
		DebugLocation(86, 8);
		} finally { DebugExitRule(GrammarFileName, "nil"); }
		return retval;

	}
	// $ANTLR end "nil"

	public class nil2_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_nil2();
	partial void Leave_nil2();

	// $ANTLR start "nil2"
	// MathLang.g:87:1: nil2 : '()' -> NIL ;
	[GrammarRule("nil2")]
	private MathLangParser.nil2_return nil2()
	{
		Enter_nil2();
		EnterRule("nil2", 8);
		TraceIn("nil2", 8);
		MathLangParser.nil2_return retval = new MathLangParser.nil2_return();
		retval.Start = (IToken)input.LT(1);
		int nil2_StartIndex = input.Index;
		object root_0 = null;

		IToken string_literal30=null;

		object string_literal30_tree=null;
		RewriteRuleITokenStream stream_35=new RewriteRuleITokenStream(adaptor,"token 35");

		try { DebugEnterRule(GrammarFileName, "nil2");
		DebugLocation(87, 17);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 8)) { return retval; }
			// MathLang.g:87:5: ( '()' -> NIL )
			DebugEnterAlt(1);
			// MathLang.g:87:7: '()'
			{
			DebugLocation(87, 7);
			string_literal30=(IToken)Match(input,35,Follow._35_in_nil2851); if (state.failed) return retval; 
			if ( state.backtracking == 0 ) stream_35.Add(string_literal30);



			{
			// AST REWRITE
			// elements: 
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 87:12: -> NIL
			{
				DebugLocation(87, 15);
				adaptor.AddChild(root_0, (object)adaptor.Create(NIL, "NIL"));

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("nil2", 8);
			LeaveRule("nil2", 8);
			Leave_nil2();
			if (state.backtracking > 0) { Memoize(input, 8, nil2_StartIndex); }
		}
		DebugLocation(87, 17);
		} finally { DebugExitRule(GrammarFileName, "nil2"); }
		return retval;

	}
	// $ANTLR end "nil2"

	public class list_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_list();
	partial void Leave_list();

	// $ANTLR start "list"
	// MathLang.g:89:1: list : ( QUOTE ( ( '(' ( ATOM | WORD )+ ')' ) | ( group | WORD ) ) ) ;
	[GrammarRule("list")]
	private MathLangParser.list_return list()
	{
		Enter_list();
		EnterRule("list", 9);
		TraceIn("list", 9);
		MathLangParser.list_return retval = new MathLangParser.list_return();
		retval.Start = (IToken)input.LT(1);
		int list_StartIndex = input.Index;
		object root_0 = null;

		IToken QUOTE31=null;
		IToken char_literal32=null;
		IToken set33=null;
		IToken char_literal34=null;
		IToken WORD36=null;
		MathLangParser.group_return group35 = default(MathLangParser.group_return);

		object QUOTE31_tree=null;
		object char_literal32_tree=null;
		object set33_tree=null;
		object char_literal34_tree=null;
		object WORD36_tree=null;

		try { DebugEnterRule(GrammarFileName, "list");
		DebugLocation(89, 63);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 9)) { return retval; }
			// MathLang.g:89:5: ( ( QUOTE ( ( '(' ( ATOM | WORD )+ ')' ) | ( group | WORD ) ) ) )
			DebugEnterAlt(1);
			// MathLang.g:89:7: ( QUOTE ( ( '(' ( ATOM | WORD )+ ')' ) | ( group | WORD ) ) )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(89, 7);
			// MathLang.g:89:7: ( QUOTE ( ( '(' ( ATOM | WORD )+ ')' ) | ( group | WORD ) ) )
			DebugEnterAlt(1);
			// MathLang.g:89:8: QUOTE ( ( '(' ( ATOM | WORD )+ ')' ) | ( group | WORD ) )
			{
			DebugLocation(89, 13);
			QUOTE31=(IToken)Match(input,QUOTE,Follow._QUOTE_in_list863); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			QUOTE31_tree = (object)adaptor.Create(QUOTE31);
			root_0 = (object)adaptor.BecomeRoot(QUOTE31_tree, root_0);
			}
			DebugLocation(89, 15);
			// MathLang.g:89:15: ( ( '(' ( ATOM | WORD )+ ')' ) | ( group | WORD ) )
			int alt11=2;
			try { DebugEnterSubRule(11);
			try { DebugEnterDecision(11, decisionCanBacktrack[11]);
			int LA11_0 = input.LA(1);

			if ((LA11_0==33))
			{
				switch (input.LA(2))
				{
				case WORD:
					{
					switch (input.LA(3))
					{
					case 33:
						{
						alt11=2;
						}
						break;
					case 34:
						{
						int LA11_5 = input.LA(4);

						if ((EvaluatePredicate(synpred23_MathLang_fragment)))
						{
							alt11=1;
						}
						else if ((true))
						{
							alt11=2;
						}
						else
						{
							if (state.backtracking>0) {state.failed=true; return retval;}
							NoViableAltException nvae = new NoViableAltException("", 11, 5, input);

							DebugRecognitionException(nvae);
							throw nvae;
						}
						}
						break;
					case ATOM:
					case WORD:
						{
						alt11=1;
						}
						break;
					default:
						{
							if (state.backtracking>0) {state.failed=true; return retval;}
							NoViableAltException nvae = new NoViableAltException("", 11, 3, input);

							DebugRecognitionException(nvae);
							throw nvae;
						}
					}

					}
					break;
				case ATOM:
					{
					int LA11_4 = input.LA(3);

					if ((LA11_4==34))
					{
						int LA11_5 = input.LA(4);

						if ((EvaluatePredicate(synpred23_MathLang_fragment)))
						{
							alt11=1;
						}
						else if ((true))
						{
							alt11=2;
						}
						else
						{
							if (state.backtracking>0) {state.failed=true; return retval;}
							NoViableAltException nvae = new NoViableAltException("", 11, 5, input);

							DebugRecognitionException(nvae);
							throw nvae;
						}
					}
					else if (((LA11_4>=ATOM && LA11_4<=WORD)))
					{
						alt11=1;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 11, 4, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
					}
					break;
				case NIL:
				case ADD:
				case SUB:
				case MUL:
				case DIV:
				case GE:
				case LE:
				case NEQUALS:
				case GT:
				case LT:
				case EQUALS:
				case 33:
				case 35:
					{
					alt11=2;
					}
					break;
				default:
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 11, 1, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}

			}
			else if ((LA11_0==NIL||(LA11_0>=ATOM && LA11_0<=WORD)||LA11_0==35))
			{
				alt11=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 11, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(11); }
			switch (alt11)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:89:16: ( '(' ( ATOM | WORD )+ ')' )
				{
				DebugLocation(89, 16);
				// MathLang.g:89:16: ( '(' ( ATOM | WORD )+ ')' )
				DebugEnterAlt(1);
				// MathLang.g:89:18: '(' ( ATOM | WORD )+ ')'
				{
				DebugLocation(89, 21);
				char_literal32=(IToken)Match(input,33,Follow._33_in_list869); if (state.failed) return retval;
				DebugLocation(89, 23);
				// MathLang.g:89:23: ( ATOM | WORD )+
				int cnt9=0;
				try { DebugEnterSubRule(9);
				while (true)
				{
					int alt9=2;
					try { DebugEnterDecision(9, decisionCanBacktrack[9]);
					int LA9_0 = input.LA(1);

					if (((LA9_0>=ATOM && LA9_0<=WORD)))
					{
						alt9=1;
					}


					} finally { DebugExitDecision(9); }
					switch (alt9)
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:
						{
						DebugLocation(89, 23);
						set33=(IToken)input.LT(1);
						if ((input.LA(1)>=ATOM && input.LA(1)<=WORD))
						{
							input.Consume();
							if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set33));
							state.errorRecovery=false;state.failed=false;
						}
						else
						{
							if (state.backtracking>0) {state.failed=true; return retval;}
							MismatchedSetException mse = new MismatchedSetException(null,input);
							DebugRecognitionException(mse);
							throw mse;
						}


						}
						break;

					default:
						if (cnt9 >= 1)
							goto loop9;

						if (state.backtracking>0) {state.failed=true; return retval;}
						EarlyExitException eee9 = new EarlyExitException( 9, input );
						DebugRecognitionException(eee9);
						throw eee9;
					}
					cnt9++;
				}
				loop9:
					;

				} finally { DebugExitSubRule(9); }

				DebugLocation(89, 41);
				char_literal34=(IToken)Match(input,34,Follow._34_in_list881); if (state.failed) return retval;

				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:89:47: ( group | WORD )
				{
				DebugLocation(89, 47);
				// MathLang.g:89:47: ( group | WORD )
				int alt10=2;
				try { DebugEnterSubRule(10);
				try { DebugEnterDecision(10, decisionCanBacktrack[10]);
				int LA10_0 = input.LA(1);

				if ((LA10_0==NIL||LA10_0==ATOM||LA10_0==33||LA10_0==35))
				{
					alt10=1;
				}
				else if ((LA10_0==WORD))
				{
					alt10=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 10, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				} finally { DebugExitDecision(10); }
				switch (alt10)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:89:48: group
					{
					DebugLocation(89, 48);
					PushFollow(Follow._group_in_list889);
					group35=group();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group35.Tree);

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// MathLang.g:89:56: WORD
					{
					DebugLocation(89, 56);
					WORD36=(IToken)Match(input,WORD,Follow._WORD_in_list893); if (state.failed) return retval;
					if ( state.backtracking==0 ) {
					WORD36_tree = (object)adaptor.Create(WORD36);
					adaptor.AddChild(root_0, WORD36_tree);
					}

					}
					break;

				}
				} finally { DebugExitSubRule(10); }


				}
				break;

			}
			} finally { DebugExitSubRule(11); }


			}


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("list", 9);
			LeaveRule("list", 9);
			Leave_list();
			if (state.backtracking > 0) { Memoize(input, 9, list_StartIndex); }
		}
		DebugLocation(89, 63);
		} finally { DebugExitRule(GrammarFileName, "list"); }
		return retval;

	}
	// $ANTLR end "list"

	public class argumentListLike_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_argumentListLike();
	partial void Leave_argumentListLike();

	// $ANTLR start "argumentListLike"
	// MathLang.g:92:1: argumentListLike : ( list | nil | cdr | cons | nil2 );
	[GrammarRule("argumentListLike")]
	private MathLangParser.argumentListLike_return argumentListLike()
	{
		Enter_argumentListLike();
		EnterRule("argumentListLike", 10);
		TraceIn("argumentListLike", 10);
		MathLangParser.argumentListLike_return retval = new MathLangParser.argumentListLike_return();
		retval.Start = (IToken)input.LT(1);
		int argumentListLike_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.list_return list37 = default(MathLangParser.list_return);
		MathLangParser.nil_return nil38 = default(MathLangParser.nil_return);
		MathLangParser.cdr_return cdr39 = default(MathLangParser.cdr_return);
		MathLangParser.cons_return cons40 = default(MathLangParser.cons_return);
		MathLangParser.nil2_return nil241 = default(MathLangParser.nil2_return);


		try { DebugEnterRule(GrammarFileName, "argumentListLike");
		DebugLocation(92, 54);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 10)) { return retval; }
			// MathLang.g:92:17: ( list | nil | cdr | cons | nil2 )
			int alt12=5;
			try { DebugEnterDecision(12, decisionCanBacktrack[12]);
			switch (input.LA(1))
			{
			case QUOTE:
				{
				alt12=1;
				}
				break;
			case NIL:
				{
				alt12=2;
				}
				break;
			case 33:
				{
				int LA12_3 = input.LA(2);

				if ((LA12_3==CDR))
				{
					alt12=3;
				}
				else if ((LA12_3==CONS))
				{
					alt12=4;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 12, 3, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			case 35:
				{
				alt12=5;
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 12, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(12); }
			switch (alt12)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:92:19: list
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(92, 19);
				PushFollow(Follow._list_in_argumentListLike905);
				list37=list();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, list37.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:92:26: nil
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(92, 26);
				PushFollow(Follow._nil_in_argumentListLike909);
				nil38=nil();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, nil38.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:92:32: cdr
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(92, 32);
				PushFollow(Follow._cdr_in_argumentListLike913);
				cdr39=cdr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cdr39.Tree);

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:92:38: cons
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(92, 38);
				PushFollow(Follow._cons_in_argumentListLike917);
				cons40=cons();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cons40.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:92:45: nil2
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(92, 45);
				PushFollow(Follow._nil2_in_argumentListLike921);
				nil241=nil2();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, nil241.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("argumentListLike", 10);
			LeaveRule("argumentListLike", 10);
			Leave_argumentListLike();
			if (state.backtracking > 0) { Memoize(input, 10, argumentListLike_StartIndex); }
		}
		DebugLocation(92, 54);
		} finally { DebugExitRule(GrammarFileName, "argumentListLike"); }
		return retval;

	}
	// $ANTLR end "argumentListLike"

	public class argumentATOMLike_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_argumentATOMLike();
	partial void Leave_argumentATOMLike();

	// $ANTLR start "argumentATOMLike"
	// MathLang.g:93:1: argumentATOMLike : ( ( QUOTE ( ATOM | WORD ) ) | car );
	[GrammarRule("argumentATOMLike")]
	private MathLangParser.argumentATOMLike_return argumentATOMLike()
	{
		Enter_argumentATOMLike();
		EnterRule("argumentATOMLike", 11);
		TraceIn("argumentATOMLike", 11);
		MathLangParser.argumentATOMLike_return retval = new MathLangParser.argumentATOMLike_return();
		retval.Start = (IToken)input.LT(1);
		int argumentATOMLike_StartIndex = input.Index;
		object root_0 = null;

		IToken QUOTE42=null;
		IToken set43=null;
		MathLangParser.car_return car44 = default(MathLangParser.car_return);

		object QUOTE42_tree=null;
		object set43_tree=null;

		try { DebugEnterRule(GrammarFileName, "argumentATOMLike");
		DebugLocation(93, 54);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 11)) { return retval; }
			// MathLang.g:93:17: ( ( QUOTE ( ATOM | WORD ) ) | car )
			int alt13=2;
			try { DebugEnterDecision(13, decisionCanBacktrack[13]);
			int LA13_0 = input.LA(1);

			if ((LA13_0==QUOTE))
			{
				alt13=1;
			}
			else if ((LA13_0==33))
			{
				alt13=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 13, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(13); }
			switch (alt13)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:93:19: ( QUOTE ( ATOM | WORD ) )
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(93, 19);
				// MathLang.g:93:19: ( QUOTE ( ATOM | WORD ) )
				DebugEnterAlt(1);
				// MathLang.g:93:20: QUOTE ( ATOM | WORD )
				{
				DebugLocation(93, 25);
				QUOTE42=(IToken)Match(input,QUOTE,Follow._QUOTE_in_argumentATOMLike934); if (state.failed) return retval;
				if ( state.backtracking == 0 ) {
				QUOTE42_tree = (object)adaptor.Create(QUOTE42);
				root_0 = (object)adaptor.BecomeRoot(QUOTE42_tree, root_0);
				}
				DebugLocation(93, 27);
				set43=(IToken)input.LT(1);
				if ((input.LA(1)>=ATOM && input.LA(1)<=WORD))
				{
					input.Consume();
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (object)adaptor.Create(set43));
					state.errorRecovery=false;state.failed=false;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					MismatchedSetException mse = new MismatchedSetException(null,input);
					DebugRecognitionException(mse);
					throw mse;
				}


				}


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:93:44: car
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(93, 44);
				PushFollow(Follow._car_in_argumentATOMLike948);
				car44=car();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, car44.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("argumentATOMLike", 11);
			LeaveRule("argumentATOMLike", 11);
			Leave_argumentATOMLike();
			if (state.backtracking > 0) { Memoize(input, 11, argumentATOMLike_StartIndex); }
		}
		DebugLocation(93, 54);
		} finally { DebugExitRule(GrammarFileName, "argumentATOMLike"); }
		return retval;

	}
	// $ANTLR end "argumentATOMLike"

	public class allArguments_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_allArguments();
	partial void Leave_allArguments();

	// $ANTLR start "allArguments"
	// MathLang.g:94:1: allArguments : ( argumentListLike | argumentATOMLike );
	[GrammarRule("allArguments")]
	private MathLangParser.allArguments_return allArguments()
	{
		Enter_allArguments();
		EnterRule("allArguments", 12);
		TraceIn("allArguments", 12);
		MathLangParser.allArguments_return retval = new MathLangParser.allArguments_return();
		retval.Start = (IToken)input.LT(1);
		int allArguments_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.argumentListLike_return argumentListLike45 = default(MathLangParser.argumentListLike_return);
		MathLangParser.argumentATOMLike_return argumentATOMLike46 = default(MathLangParser.argumentATOMLike_return);


		try { DebugEnterRule(GrammarFileName, "allArguments");
		DebugLocation(94, 54);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 12)) { return retval; }
			// MathLang.g:94:13: ( argumentListLike | argumentATOMLike )
			int alt14=2;
			try { DebugEnterDecision(14, decisionCanBacktrack[14]);
			switch (input.LA(1))
			{
			case QUOTE:
				{
				switch (input.LA(2))
				{
				case ATOM:
					{
					int LA14_4 = input.LA(3);

					if ((EvaluatePredicate(synpred31_MathLang_fragment)))
					{
						alt14=1;
					}
					else if ((true))
					{
						alt14=2;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 14, 4, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
					}
					break;
				case NIL:
				case 33:
				case 35:
					{
					alt14=1;
					}
					break;
				case WORD:
					{
					int LA14_5 = input.LA(3);

					if ((EvaluatePredicate(synpred31_MathLang_fragment)))
					{
						alt14=1;
					}
					else if ((true))
					{
						alt14=2;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 14, 5, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
					}
					break;
				default:
					{
						if (state.backtracking>0) {state.failed=true; return retval;}
						NoViableAltException nvae = new NoViableAltException("", 14, 1, input);

						DebugRecognitionException(nvae);
						throw nvae;
					}
				}

				}
				break;
			case NIL:
			case 35:
				{
				alt14=1;
				}
				break;
			case 33:
				{
				int LA14_3 = input.LA(2);

				if (((LA14_3>=CDR && LA14_3<=CONS)))
				{
					alt14=1;
				}
				else if ((LA14_3==CAR))
				{
					alt14=2;
				}
				else
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 14, 3, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
				}
				break;
			default:
				{
					if (state.backtracking>0) {state.failed=true; return retval;}
					NoViableAltException nvae = new NoViableAltException("", 14, 0, input);

					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(14); }
			switch (alt14)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:94:15: argumentListLike
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(94, 15);
				PushFollow(Follow._argumentListLike_in_allArguments962);
				argumentListLike45=argumentListLike();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, argumentListLike45.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:94:34: argumentATOMLike
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(94, 34);
				PushFollow(Follow._argumentATOMLike_in_allArguments966);
				argumentATOMLike46=argumentATOMLike();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, argumentATOMLike46.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("allArguments", 12);
			LeaveRule("allArguments", 12);
			Leave_allArguments();
			if (state.backtracking > 0) { Memoize(input, 12, allArguments_StartIndex); }
		}
		DebugLocation(94, 54);
		} finally { DebugExitRule(GrammarFileName, "allArguments"); }
		return retval;

	}
	// $ANTLR end "allArguments"

	public class car_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_car();
	partial void Leave_car();

	// $ANTLR start "car"
	// MathLang.g:96:1: car : '(' CAR allArguments ')' ;
	[GrammarRule("car")]
	private MathLangParser.car_return car()
	{
		Enter_car();
		EnterRule("car", 13);
		TraceIn("car", 13);
		MathLangParser.car_return retval = new MathLangParser.car_return();
		retval.Start = (IToken)input.LT(1);
		int car_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal47=null;
		IToken CAR48=null;
		IToken char_literal50=null;
		MathLangParser.allArguments_return allArguments49 = default(MathLangParser.allArguments_return);

		object char_literal47_tree=null;
		object CAR48_tree=null;
		object char_literal50_tree=null;

		try { DebugEnterRule(GrammarFileName, "car");
		DebugLocation(96, 39);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 13)) { return retval; }
			// MathLang.g:96:4: ( '(' CAR allArguments ')' )
			DebugEnterAlt(1);
			// MathLang.g:96:7: '(' CAR allArguments ')'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(96, 10);
			char_literal47=(IToken)Match(input,33,Follow._33_in_car979); if (state.failed) return retval;
			DebugLocation(96, 15);
			CAR48=(IToken)Match(input,CAR,Follow._CAR_in_car982); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			CAR48_tree = (object)adaptor.Create(CAR48);
			root_0 = (object)adaptor.BecomeRoot(CAR48_tree, root_0);
			}
			DebugLocation(96, 17);
			PushFollow(Follow._allArguments_in_car985);
			allArguments49=allArguments();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, allArguments49.Tree);
			DebugLocation(96, 33);
			char_literal50=(IToken)Match(input,34,Follow._34_in_car987); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("car", 13);
			LeaveRule("car", 13);
			Leave_car();
			if (state.backtracking > 0) { Memoize(input, 13, car_StartIndex); }
		}
		DebugLocation(96, 39);
		} finally { DebugExitRule(GrammarFileName, "car"); }
		return retval;

	}
	// $ANTLR end "car"

	public class cdr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_cdr();
	partial void Leave_cdr();

	// $ANTLR start "cdr"
	// MathLang.g:97:1: cdr : '(' CDR allArguments ')' ;
	[GrammarRule("cdr")]
	private MathLangParser.cdr_return cdr()
	{
		Enter_cdr();
		EnterRule("cdr", 14);
		TraceIn("cdr", 14);
		MathLangParser.cdr_return retval = new MathLangParser.cdr_return();
		retval.Start = (IToken)input.LT(1);
		int cdr_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal51=null;
		IToken CDR52=null;
		IToken char_literal54=null;
		MathLangParser.allArguments_return allArguments53 = default(MathLangParser.allArguments_return);

		object char_literal51_tree=null;
		object CDR52_tree=null;
		object char_literal54_tree=null;

		try { DebugEnterRule(GrammarFileName, "cdr");
		DebugLocation(97, 39);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 14)) { return retval; }
			// MathLang.g:97:4: ( '(' CDR allArguments ')' )
			DebugEnterAlt(1);
			// MathLang.g:97:7: '(' CDR allArguments ')'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(97, 10);
			char_literal51=(IToken)Match(input,33,Follow._33_in_cdr1001); if (state.failed) return retval;
			DebugLocation(97, 15);
			CDR52=(IToken)Match(input,CDR,Follow._CDR_in_cdr1004); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			CDR52_tree = (object)adaptor.Create(CDR52);
			root_0 = (object)adaptor.BecomeRoot(CDR52_tree, root_0);
			}
			DebugLocation(97, 17);
			PushFollow(Follow._allArguments_in_cdr1007);
			allArguments53=allArguments();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, allArguments53.Tree);
			DebugLocation(97, 33);
			char_literal54=(IToken)Match(input,34,Follow._34_in_cdr1009); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("cdr", 14);
			LeaveRule("cdr", 14);
			Leave_cdr();
			if (state.backtracking > 0) { Memoize(input, 14, cdr_StartIndex); }
		}
		DebugLocation(97, 39);
		} finally { DebugExitRule(GrammarFileName, "cdr"); }
		return retval;

	}
	// $ANTLR end "cdr"

	public class cons_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_cons();
	partial void Leave_cons();

	// $ANTLR start "cons"
	// MathLang.g:98:1: cons : '(' CONS allArguments allArguments ')' ;
	[GrammarRule("cons")]
	private MathLangParser.cons_return cons()
	{
		Enter_cons();
		EnterRule("cons", 15);
		TraceIn("cons", 15);
		MathLangParser.cons_return retval = new MathLangParser.cons_return();
		retval.Start = (IToken)input.LT(1);
		int cons_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal55=null;
		IToken CONS56=null;
		IToken char_literal59=null;
		MathLangParser.allArguments_return allArguments57 = default(MathLangParser.allArguments_return);
		MathLangParser.allArguments_return allArguments58 = default(MathLangParser.allArguments_return);

		object char_literal55_tree=null;
		object CONS56_tree=null;
		object char_literal59_tree=null;

		try { DebugEnterRule(GrammarFileName, "cons");
		DebugLocation(98, 48);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 15)) { return retval; }
			// MathLang.g:98:5: ( '(' CONS allArguments allArguments ')' )
			DebugEnterAlt(1);
			// MathLang.g:98:7: '(' CONS allArguments allArguments ')'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(98, 10);
			char_literal55=(IToken)Match(input,33,Follow._33_in_cons1022); if (state.failed) return retval;
			DebugLocation(98, 16);
			CONS56=(IToken)Match(input,CONS,Follow._CONS_in_cons1025); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			CONS56_tree = (object)adaptor.Create(CONS56);
			root_0 = (object)adaptor.BecomeRoot(CONS56_tree, root_0);
			}
			DebugLocation(98, 18);
			PushFollow(Follow._allArguments_in_cons1028);
			allArguments57=allArguments();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, allArguments57.Tree);
			DebugLocation(98, 31);
			PushFollow(Follow._allArguments_in_cons1030);
			allArguments58=allArguments();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, allArguments58.Tree);
			DebugLocation(98, 47);
			char_literal59=(IToken)Match(input,34,Follow._34_in_cons1032); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("cons", 15);
			LeaveRule("cons", 15);
			Leave_cons();
			if (state.backtracking > 0) { Memoize(input, 15, cons_StartIndex); }
		}
		DebugLocation(98, 48);
		} finally { DebugExitRule(GrammarFileName, "cons"); }
		return retval;

	}
	// $ANTLR end "cons"

	public class eq_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_eq();
	partial void Leave_eq();

	// $ANTLR start "eq"
	// MathLang.g:99:1: eq : '(' EQUAL ( allArguments allArguments ) ')' ;
	[GrammarRule("eq")]
	private MathLangParser.eq_return eq()
	{
		Enter_eq();
		EnterRule("eq", 16);
		TraceIn("eq", 16);
		MathLangParser.eq_return retval = new MathLangParser.eq_return();
		retval.Start = (IToken)input.LT(1);
		int eq_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal60=null;
		IToken EQUAL61=null;
		IToken char_literal64=null;
		MathLangParser.allArguments_return allArguments62 = default(MathLangParser.allArguments_return);
		MathLangParser.allArguments_return allArguments63 = default(MathLangParser.allArguments_return);

		object char_literal60_tree=null;
		object EQUAL61_tree=null;
		object char_literal64_tree=null;

		try { DebugEnterRule(GrammarFileName, "eq");
		DebugLocation(99, 52);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 16)) { return retval; }
			// MathLang.g:99:3: ( '(' EQUAL ( allArguments allArguments ) ')' )
			DebugEnterAlt(1);
			// MathLang.g:99:7: '(' EQUAL ( allArguments allArguments ) ')'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(99, 10);
			char_literal60=(IToken)Match(input,33,Follow._33_in_eq1042); if (state.failed) return retval;
			DebugLocation(99, 17);
			EQUAL61=(IToken)Match(input,EQUAL,Follow._EQUAL_in_eq1045); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			EQUAL61_tree = (object)adaptor.Create(EQUAL61);
			root_0 = (object)adaptor.BecomeRoot(EQUAL61_tree, root_0);
			}
			DebugLocation(99, 20);
			// MathLang.g:99:20: ( allArguments allArguments )
			DebugEnterAlt(1);
			// MathLang.g:99:21: allArguments allArguments
			{
			DebugLocation(99, 21);
			PushFollow(Follow._allArguments_in_eq1050);
			allArguments62=allArguments();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, allArguments62.Tree);
			DebugLocation(99, 34);
			PushFollow(Follow._allArguments_in_eq1052);
			allArguments63=allArguments();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, allArguments63.Tree);

			}

			DebugLocation(99, 51);
			char_literal64=(IToken)Match(input,34,Follow._34_in_eq1055); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("eq", 16);
			LeaveRule("eq", 16);
			Leave_eq();
			if (state.backtracking > 0) { Memoize(input, 16, eq_StartIndex); }
		}
		DebugLocation(99, 52);
		} finally { DebugExitRule(GrammarFileName, "eq"); }
		return retval;

	}
	// $ANTLR end "eq"

	public class nuLL_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_nuLL();
	partial void Leave_nuLL();

	// $ANTLR start "nuLL"
	// MathLang.g:100:1: nuLL : '(' NULL allArguments ')' ;
	[GrammarRule("nuLL")]
	private MathLangParser.nuLL_return nuLL()
	{
		Enter_nuLL();
		EnterRule("nuLL", 17);
		TraceIn("nuLL", 17);
		MathLangParser.nuLL_return retval = new MathLangParser.nuLL_return();
		retval.Start = (IToken)input.LT(1);
		int nuLL_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal65=null;
		IToken NULL66=null;
		IToken char_literal68=null;
		MathLangParser.allArguments_return allArguments67 = default(MathLangParser.allArguments_return);

		object char_literal65_tree=null;
		object NULL66_tree=null;
		object char_literal68_tree=null;

		try { DebugEnterRule(GrammarFileName, "nuLL");
		DebugLocation(100, 39);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 17)) { return retval; }
			// MathLang.g:100:5: ( '(' NULL allArguments ')' )
			DebugEnterAlt(1);
			// MathLang.g:100:7: '(' NULL allArguments ')'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(100, 10);
			char_literal65=(IToken)Match(input,33,Follow._33_in_nuLL1063); if (state.failed) return retval;
			DebugLocation(100, 16);
			NULL66=(IToken)Match(input,NULL,Follow._NULL_in_nuLL1066); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			NULL66_tree = (object)adaptor.Create(NULL66);
			root_0 = (object)adaptor.BecomeRoot(NULL66_tree, root_0);
			}
			DebugLocation(100, 18);
			PushFollow(Follow._allArguments_in_nuLL1069);
			allArguments67=allArguments();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, allArguments67.Tree);
			DebugLocation(100, 34);
			char_literal68=(IToken)Match(input,34,Follow._34_in_nuLL1071); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("nuLL", 17);
			LeaveRule("nuLL", 17);
			Leave_nuLL();
			if (state.backtracking > 0) { Memoize(input, 17, nuLL_StartIndex); }
		}
		DebugLocation(100, 39);
		} finally { DebugExitRule(GrammarFileName, "nuLL"); }
		return retval;

	}
	// $ANTLR end "nuLL"

	public class assign_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_assign();
	partial void Leave_assign();

	// $ANTLR start "assign"
	// MathLang.g:102:1: assign : WORD ASSIGN ( group | WORD ) ;
	[GrammarRule("assign")]
	private MathLangParser.assign_return assign()
	{
		Enter_assign();
		EnterRule("assign", 18);
		TraceIn("assign", 18);
		MathLangParser.assign_return retval = new MathLangParser.assign_return();
		retval.Start = (IToken)input.LT(1);
		int assign_StartIndex = input.Index;
		object root_0 = null;

		IToken WORD69=null;
		IToken ASSIGN70=null;
		IToken WORD72=null;
		MathLangParser.group_return group71 = default(MathLangParser.group_return);

		object WORD69_tree=null;
		object ASSIGN70_tree=null;
		object WORD72_tree=null;

		try { DebugEnterRule(GrammarFileName, "assign");
		DebugLocation(102, 35);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 18)) { return retval; }
			// MathLang.g:102:7: ( WORD ASSIGN ( group | WORD ) )
			DebugEnterAlt(1);
			// MathLang.g:102:9: WORD ASSIGN ( group | WORD )
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(102, 9);
			WORD69=(IToken)Match(input,WORD,Follow._WORD_in_assign1084); if (state.failed) return retval;
			if ( state.backtracking==0 ) {
			WORD69_tree = (object)adaptor.Create(WORD69);
			adaptor.AddChild(root_0, WORD69_tree);
			}
			DebugLocation(102, 20);
			ASSIGN70=(IToken)Match(input,ASSIGN,Follow._ASSIGN_in_assign1086); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			ASSIGN70_tree = (object)adaptor.Create(ASSIGN70);
			root_0 = (object)adaptor.BecomeRoot(ASSIGN70_tree, root_0);
			}
			DebugLocation(102, 22);
			// MathLang.g:102:22: ( group | WORD )
			int alt15=2;
			try { DebugEnterSubRule(15);
			try { DebugEnterDecision(15, decisionCanBacktrack[15]);
			int LA15_0 = input.LA(1);

			if ((LA15_0==NIL||LA15_0==ATOM||LA15_0==33||LA15_0==35))
			{
				alt15=1;
			}
			else if ((LA15_0==WORD))
			{
				alt15=2;
			}
			else
			{
				if (state.backtracking>0) {state.failed=true; return retval;}
				NoViableAltException nvae = new NoViableAltException("", 15, 0, input);

				DebugRecognitionException(nvae);
				throw nvae;
			}
			} finally { DebugExitDecision(15); }
			switch (alt15)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:102:23: group
				{
				DebugLocation(102, 23);
				PushFollow(Follow._group_in_assign1090);
				group71=group();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group71.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:102:31: WORD
				{
				DebugLocation(102, 31);
				WORD72=(IToken)Match(input,WORD,Follow._WORD_in_assign1094); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				WORD72_tree = (object)adaptor.Create(WORD72);
				adaptor.AddChild(root_0, WORD72_tree);
				}

				}
				break;

			}
			} finally { DebugExitSubRule(15); }


			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("assign", 18);
			LeaveRule("assign", 18);
			Leave_assign();
			if (state.backtracking > 0) { Memoize(input, 18, assign_StartIndex); }
		}
		DebugLocation(102, 35);
		} finally { DebugExitRule(GrammarFileName, "assign"); }
		return retval;

	}
	// $ANTLR end "assign"

	public class methodSignature_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_methodSignature();
	partial void Leave_methodSignature();

	// $ANTLR start "methodSignature"
	// MathLang.g:104:1: methodSignature : WORD '(' ( WORD )* ')' ;
	[GrammarRule("methodSignature")]
	private MathLangParser.methodSignature_return methodSignature()
	{
		Enter_methodSignature();
		EnterRule("methodSignature", 19);
		TraceIn("methodSignature", 19);
		MathLangParser.methodSignature_return retval = new MathLangParser.methodSignature_return();
		retval.Start = (IToken)input.LT(1);
		int methodSignature_StartIndex = input.Index;
		object root_0 = null;

		IToken WORD73=null;
		IToken char_literal74=null;
		IToken WORD75=null;
		IToken char_literal76=null;

		object WORD73_tree=null;
		object char_literal74_tree=null;
		object WORD75_tree=null;
		object char_literal76_tree=null;

		try { DebugEnterRule(GrammarFileName, "methodSignature");
		DebugLocation(104, 39);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 19)) { return retval; }
			// MathLang.g:104:16: ( WORD '(' ( WORD )* ')' )
			DebugEnterAlt(1);
			// MathLang.g:104:18: WORD '(' ( WORD )* ')'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(104, 22);
			WORD73=(IToken)Match(input,WORD,Follow._WORD_in_methodSignature1102); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			WORD73_tree = (object)adaptor.Create(WORD73);
			root_0 = (object)adaptor.BecomeRoot(WORD73_tree, root_0);
			}
			DebugLocation(104, 27);
			char_literal74=(IToken)Match(input,33,Follow._33_in_methodSignature1105); if (state.failed) return retval;
			DebugLocation(104, 29);
			// MathLang.g:104:29: ( WORD )*
			try { DebugEnterSubRule(16);
			while (true)
			{
				int alt16=2;
				try { DebugEnterDecision(16, decisionCanBacktrack[16]);
				int LA16_0 = input.LA(1);

				if ((LA16_0==WORD))
				{
					alt16=1;
				}


				} finally { DebugExitDecision(16); }
				switch ( alt16 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: WORD
					{
					DebugLocation(104, 29);
					WORD75=(IToken)Match(input,WORD,Follow._WORD_in_methodSignature1108); if (state.failed) return retval;
					if ( state.backtracking==0 ) {
					WORD75_tree = (object)adaptor.Create(WORD75);
					adaptor.AddChild(root_0, WORD75_tree);
					}

					}
					break;

				default:
					goto loop16;
				}
			}

			loop16:
				;

			} finally { DebugExitSubRule(16); }

			DebugLocation(104, 38);
			char_literal76=(IToken)Match(input,34,Follow._34_in_methodSignature1111); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("methodSignature", 19);
			LeaveRule("methodSignature", 19);
			Leave_methodSignature();
			if (state.backtracking > 0) { Memoize(input, 19, methodSignature_StartIndex); }
		}
		DebugLocation(104, 39);
		} finally { DebugExitRule(GrammarFileName, "methodSignature"); }
		return retval;

	}
	// $ANTLR end "methodSignature"

	public class fun_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_fun();
	partial void Leave_fun();

	// $ANTLR start "fun"
	// MathLang.g:105:1: fun : '(' DEFUN methodSignature ( expr )* ')' ;
	[GrammarRule("fun")]
	private MathLangParser.fun_return fun()
	{
		Enter_fun();
		EnterRule("fun", 20);
		TraceIn("fun", 20);
		MathLangParser.fun_return retval = new MathLangParser.fun_return();
		retval.Start = (IToken)input.LT(1);
		int fun_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal77=null;
		IToken DEFUN78=null;
		IToken char_literal81=null;
		MathLangParser.methodSignature_return methodSignature79 = default(MathLangParser.methodSignature_return);
		MathLangParser.expr_return expr80 = default(MathLangParser.expr_return);

		object char_literal77_tree=null;
		object DEFUN78_tree=null;
		object char_literal81_tree=null;

		try { DebugEnterRule(GrammarFileName, "fun");
		DebugLocation(105, 44);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 20)) { return retval; }
			// MathLang.g:105:4: ( '(' DEFUN methodSignature ( expr )* ')' )
			DebugEnterAlt(1);
			// MathLang.g:105:6: '(' DEFUN methodSignature ( expr )* ')'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(105, 9);
			char_literal77=(IToken)Match(input,33,Follow._33_in_fun1119); if (state.failed) return retval;
			DebugLocation(105, 16);
			DEFUN78=(IToken)Match(input,DEFUN,Follow._DEFUN_in_fun1122); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			DEFUN78_tree = (object)adaptor.Create(DEFUN78);
			root_0 = (object)adaptor.BecomeRoot(DEFUN78_tree, root_0);
			}
			DebugLocation(105, 18);
			PushFollow(Follow._methodSignature_in_fun1125);
			methodSignature79=methodSignature();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodSignature79.Tree);
			DebugLocation(105, 34);
			// MathLang.g:105:34: ( expr )*
			try { DebugEnterSubRule(17);
			while (true)
			{
				int alt17=2;
				try { DebugEnterDecision(17, decisionCanBacktrack[17]);
				int LA17_0 = input.LA(1);

				if (((LA17_0>=NIL && LA17_0<=QUOTE)||(LA17_0>=ATOM && LA17_0<=WORD)||LA17_0==33||(LA17_0>=35 && LA17_0<=36)))
				{
					alt17=1;
				}


				} finally { DebugExitDecision(17); }
				switch ( alt17 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: expr
					{
					DebugLocation(105, 34);
					PushFollow(Follow._expr_in_fun1127);
					expr80=expr();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr80.Tree);

					}
					break;

				default:
					goto loop17;
				}
			}

			loop17:
				;

			} finally { DebugExitSubRule(17); }

			DebugLocation(105, 43);
			char_literal81=(IToken)Match(input,34,Follow._34_in_fun1130); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("fun", 20);
			LeaveRule("fun", 20);
			Leave_fun();
			if (state.backtracking > 0) { Memoize(input, 20, fun_StartIndex); }
		}
		DebugLocation(105, 44);
		} finally { DebugExitRule(GrammarFileName, "fun"); }
		return retval;

	}
	// $ANTLR end "fun"

	public class methodExe_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_methodExe();
	partial void Leave_methodExe();

	// $ANTLR start "methodExe"
	// MathLang.g:107:1: methodExe : '(' WORD '(' ( group | WORD )* ')' ')' ;
	[GrammarRule("methodExe")]
	private MathLangParser.methodExe_return methodExe()
	{
		Enter_methodExe();
		EnterRule("methodExe", 21);
		TraceIn("methodExe", 21);
		MathLangParser.methodExe_return retval = new MathLangParser.methodExe_return();
		retval.Start = (IToken)input.LT(1);
		int methodExe_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal82=null;
		IToken WORD83=null;
		IToken char_literal84=null;
		IToken WORD86=null;
		IToken char_literal87=null;
		IToken char_literal88=null;
		MathLangParser.group_return group85 = default(MathLangParser.group_return);

		object char_literal82_tree=null;
		object WORD83_tree=null;
		object char_literal84_tree=null;
		object WORD86_tree=null;
		object char_literal87_tree=null;
		object char_literal88_tree=null;

		try { DebugEnterRule(GrammarFileName, "methodExe");
		DebugLocation(107, 52);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 21)) { return retval; }
			// MathLang.g:107:10: ( '(' WORD '(' ( group | WORD )* ')' ')' )
			DebugEnterAlt(1);
			// MathLang.g:107:12: '(' WORD '(' ( group | WORD )* ')' ')'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(107, 15);
			char_literal82=(IToken)Match(input,33,Follow._33_in_methodExe1139); if (state.failed) return retval;
			DebugLocation(107, 21);
			WORD83=(IToken)Match(input,WORD,Follow._WORD_in_methodExe1142); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			WORD83_tree = (object)adaptor.Create(WORD83);
			root_0 = (object)adaptor.BecomeRoot(WORD83_tree, root_0);
			}
			DebugLocation(107, 26);
			char_literal84=(IToken)Match(input,33,Follow._33_in_methodExe1145); if (state.failed) return retval;
			DebugLocation(107, 28);
			// MathLang.g:107:28: ( group | WORD )*
			try { DebugEnterSubRule(18);
			while (true)
			{
				int alt18=3;
				try { DebugEnterDecision(18, decisionCanBacktrack[18]);
				int LA18_0 = input.LA(1);

				if ((LA18_0==NIL||LA18_0==ATOM||LA18_0==33||LA18_0==35))
				{
					alt18=1;
				}
				else if ((LA18_0==WORD))
				{
					alt18=2;
				}


				} finally { DebugExitDecision(18); }
				switch ( alt18 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:107:29: group
					{
					DebugLocation(107, 29);
					PushFollow(Follow._group_in_methodExe1149);
					group85=group();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group85.Tree);

					}
					break;
				case 2:
					DebugEnterAlt(2);
					// MathLang.g:107:37: WORD
					{
					DebugLocation(107, 37);
					WORD86=(IToken)Match(input,WORD,Follow._WORD_in_methodExe1153); if (state.failed) return retval;
					if ( state.backtracking==0 ) {
					WORD86_tree = (object)adaptor.Create(WORD86);
					adaptor.AddChild(root_0, WORD86_tree);
					}

					}
					break;

				default:
					goto loop18;
				}
			}

			loop18:
				;

			} finally { DebugExitSubRule(18); }

			DebugLocation(107, 47);
			char_literal87=(IToken)Match(input,34,Follow._34_in_methodExe1157); if (state.failed) return retval;
			DebugLocation(107, 52);
			char_literal88=(IToken)Match(input,34,Follow._34_in_methodExe1160); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("methodExe", 21);
			LeaveRule("methodExe", 21);
			Leave_methodExe();
			if (state.backtracking > 0) { Memoize(input, 21, methodExe_StartIndex); }
		}
		DebugLocation(107, 52);
		} finally { DebugExitRule(GrammarFileName, "methodExe"); }
		return retval;

	}
	// $ANTLR end "methodExe"

	public class myif_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_myif();
	partial void Leave_myif();

	// $ANTLR start "myif"
	// MathLang.g:109:1: myif : '(' IF compare expr ( expr )? ')' ;
	[GrammarRule("myif")]
	private MathLangParser.myif_return myif()
	{
		Enter_myif();
		EnterRule("myif", 22);
		TraceIn("myif", 22);
		MathLangParser.myif_return retval = new MathLangParser.myif_return();
		retval.Start = (IToken)input.LT(1);
		int myif_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal89=null;
		IToken IF90=null;
		IToken char_literal94=null;
		MathLangParser.compare_return compare91 = default(MathLangParser.compare_return);
		MathLangParser.expr_return expr92 = default(MathLangParser.expr_return);
		MathLangParser.expr_return expr93 = default(MathLangParser.expr_return);

		object char_literal89_tree=null;
		object IF90_tree=null;
		object char_literal94_tree=null;

		try { DebugEnterRule(GrammarFileName, "myif");
		DebugLocation(109, 39);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 22)) { return retval; }
			// MathLang.g:109:5: ( '(' IF compare expr ( expr )? ')' )
			DebugEnterAlt(1);
			// MathLang.g:109:7: '(' IF compare expr ( expr )? ')'
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(109, 10);
			char_literal89=(IToken)Match(input,33,Follow._33_in_myif1168); if (state.failed) return retval;
			DebugLocation(109, 14);
			IF90=(IToken)Match(input,IF,Follow._IF_in_myif1171); if (state.failed) return retval;
			if ( state.backtracking == 0 ) {
			IF90_tree = (object)adaptor.Create(IF90);
			root_0 = (object)adaptor.BecomeRoot(IF90_tree, root_0);
			}
			DebugLocation(109, 16);
			PushFollow(Follow._compare_in_myif1174);
			compare91=compare();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, compare91.Tree);
			DebugLocation(109, 24);
			PushFollow(Follow._expr_in_myif1176);
			expr92=expr();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr92.Tree);
			DebugLocation(109, 29);
			// MathLang.g:109:29: ( expr )?
			int alt19=2;
			try { DebugEnterSubRule(19);
			try { DebugEnterDecision(19, decisionCanBacktrack[19]);
			int LA19_0 = input.LA(1);

			if (((LA19_0>=NIL && LA19_0<=QUOTE)||(LA19_0>=ATOM && LA19_0<=WORD)||LA19_0==33||(LA19_0>=35 && LA19_0<=36)))
			{
				alt19=1;
			}
			} finally { DebugExitDecision(19); }
			switch (alt19)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:0:0: expr
				{
				DebugLocation(109, 29);
				PushFollow(Follow._expr_in_myif1178);
				expr93=expr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, expr93.Tree);

				}
				break;

			}
			} finally { DebugExitSubRule(19); }

			DebugLocation(109, 38);
			char_literal94=(IToken)Match(input,34,Follow._34_in_myif1181); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("myif", 22);
			LeaveRule("myif", 22);
			Leave_myif();
			if (state.backtracking > 0) { Memoize(input, 22, myif_StartIndex); }
		}
		DebugLocation(109, 39);
		} finally { DebugExitRule(GrammarFileName, "myif"); }
		return retval;

	}
	// $ANTLR end "myif"

	public class expr_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_expr();
	partial void Leave_expr();

	// $ANTLR start "expr"
	// MathLang.g:111:1: expr : ( group | dotPair | '\"' WORD '\"' | list | car | cdr | cons | eq | nil | nil2 | nuLL | assign | fun | methodExe | WORD | myif );
	[GrammarRule("expr")]
	private MathLangParser.expr_return expr()
	{
		Enter_expr();
		EnterRule("expr", 23);
		TraceIn("expr", 23);
		MathLangParser.expr_return retval = new MathLangParser.expr_return();
		retval.Start = (IToken)input.LT(1);
		int expr_StartIndex = input.Index;
		object root_0 = null;

		IToken char_literal97=null;
		IToken WORD98=null;
		IToken char_literal99=null;
		IToken WORD111=null;
		MathLangParser.group_return group95 = default(MathLangParser.group_return);
		MathLangParser.dotPair_return dotPair96 = default(MathLangParser.dotPair_return);
		MathLangParser.list_return list100 = default(MathLangParser.list_return);
		MathLangParser.car_return car101 = default(MathLangParser.car_return);
		MathLangParser.cdr_return cdr102 = default(MathLangParser.cdr_return);
		MathLangParser.cons_return cons103 = default(MathLangParser.cons_return);
		MathLangParser.eq_return eq104 = default(MathLangParser.eq_return);
		MathLangParser.nil_return nil105 = default(MathLangParser.nil_return);
		MathLangParser.nil2_return nil2106 = default(MathLangParser.nil2_return);
		MathLangParser.nuLL_return nuLL107 = default(MathLangParser.nuLL_return);
		MathLangParser.assign_return assign108 = default(MathLangParser.assign_return);
		MathLangParser.fun_return fun109 = default(MathLangParser.fun_return);
		MathLangParser.methodExe_return methodExe110 = default(MathLangParser.methodExe_return);
		MathLangParser.myif_return myif112 = default(MathLangParser.myif_return);

		object char_literal97_tree=null;
		object WORD98_tree=null;
		object char_literal99_tree=null;
		object WORD111_tree=null;

		try { DebugEnterRule(GrammarFileName, "expr");
		DebugLocation(111, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 23)) { return retval; }
			// MathLang.g:111:5: ( group | dotPair | '\"' WORD '\"' | list | car | cdr | cons | eq | nil | nil2 | nuLL | assign | fun | methodExe | WORD | myif )
			int alt20=16;
			try { DebugEnterDecision(20, decisionCanBacktrack[20]);
			try
			{
				alt20 = dfa20.Predict(input);
			}
			catch (NoViableAltException nvae)
			{
				DebugRecognitionException(nvae);
				throw;
			}
			} finally { DebugExitDecision(20); }
			switch (alt20)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:112:3: group
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(112, 3);
				PushFollow(Follow._group_in_expr1192);
				group95=group();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, group95.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// MathLang.g:113:3: dotPair
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(113, 3);
				PushFollow(Follow._dotPair_in_expr1196);
				dotPair96=dotPair();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, dotPair96.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// MathLang.g:114:3: '\"' WORD '\"'
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(114, 6);
				char_literal97=(IToken)Match(input,36,Follow._36_in_expr1200); if (state.failed) return retval;
				DebugLocation(114, 8);
				WORD98=(IToken)Match(input,WORD,Follow._WORD_in_expr1203); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				WORD98_tree = (object)adaptor.Create(WORD98);
				adaptor.AddChild(root_0, WORD98_tree);
				}
				DebugLocation(114, 16);
				char_literal99=(IToken)Match(input,36,Follow._36_in_expr1205); if (state.failed) return retval;

				}
				break;
			case 4:
				DebugEnterAlt(4);
				// MathLang.g:115:3: list
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(115, 3);
				PushFollow(Follow._list_in_expr1210);
				list100=list();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, list100.Tree);

				}
				break;
			case 5:
				DebugEnterAlt(5);
				// MathLang.g:116:3: car
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(116, 3);
				PushFollow(Follow._car_in_expr1214);
				car101=car();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, car101.Tree);

				}
				break;
			case 6:
				DebugEnterAlt(6);
				// MathLang.g:117:3: cdr
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(117, 3);
				PushFollow(Follow._cdr_in_expr1218);
				cdr102=cdr();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cdr102.Tree);

				}
				break;
			case 7:
				DebugEnterAlt(7);
				// MathLang.g:118:3: cons
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(118, 3);
				PushFollow(Follow._cons_in_expr1222);
				cons103=cons();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cons103.Tree);

				}
				break;
			case 8:
				DebugEnterAlt(8);
				// MathLang.g:119:3: eq
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(119, 3);
				PushFollow(Follow._eq_in_expr1226);
				eq104=eq();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, eq104.Tree);

				}
				break;
			case 9:
				DebugEnterAlt(9);
				// MathLang.g:120:3: nil
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(120, 3);
				PushFollow(Follow._nil_in_expr1230);
				nil105=nil();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, nil105.Tree);

				}
				break;
			case 10:
				DebugEnterAlt(10);
				// MathLang.g:121:3: nil2
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(121, 3);
				PushFollow(Follow._nil2_in_expr1234);
				nil2106=nil2();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, nil2106.Tree);

				}
				break;
			case 11:
				DebugEnterAlt(11);
				// MathLang.g:122:3: nuLL
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(122, 3);
				PushFollow(Follow._nuLL_in_expr1238);
				nuLL107=nuLL();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, nuLL107.Tree);

				}
				break;
			case 12:
				DebugEnterAlt(12);
				// MathLang.g:123:3: assign
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(123, 3);
				PushFollow(Follow._assign_in_expr1242);
				assign108=assign();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assign108.Tree);

				}
				break;
			case 13:
				DebugEnterAlt(13);
				// MathLang.g:124:3: fun
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(124, 3);
				PushFollow(Follow._fun_in_expr1246);
				fun109=fun();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, fun109.Tree);

				}
				break;
			case 14:
				DebugEnterAlt(14);
				// MathLang.g:125:3: methodExe
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(125, 3);
				PushFollow(Follow._methodExe_in_expr1250);
				methodExe110=methodExe();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, methodExe110.Tree);

				}
				break;
			case 15:
				DebugEnterAlt(15);
				// MathLang.g:126:3: WORD
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(126, 3);
				WORD111=(IToken)Match(input,WORD,Follow._WORD_in_expr1254); if (state.failed) return retval;
				if ( state.backtracking==0 ) {
				WORD111_tree = (object)adaptor.Create(WORD111);
				adaptor.AddChild(root_0, WORD111_tree);
				}

				}
				break;
			case 16:
				DebugEnterAlt(16);
				// MathLang.g:127:3: myif
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(127, 3);
				PushFollow(Follow._myif_in_expr1258);
				myif112=myif();
				PopFollow();
				if (state.failed) return retval;
				if ( state.backtracking == 0 ) adaptor.AddChild(root_0, myif112.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expr", 23);
			LeaveRule("expr", 23);
			Leave_expr();
			if (state.backtracking > 0) { Memoize(input, 23, expr_StartIndex); }
		}
		DebugLocation(128, 0);
		} finally { DebugExitRule(GrammarFileName, "expr"); }
		return retval;

	}
	// $ANTLR end "expr"

	public class program_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_program();
	partial void Leave_program();

	// $ANTLR start "program"
	// MathLang.g:130:1: program : ( expr )* -> ^( BLOCK ( expr )* ) ;
	[GrammarRule("program")]
	private MathLangParser.program_return program()
	{
		Enter_program();
		EnterRule("program", 24);
		TraceIn("program", 24);
		MathLangParser.program_return retval = new MathLangParser.program_return();
		retval.Start = (IToken)input.LT(1);
		int program_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.expr_return expr113 = default(MathLangParser.expr_return);

		RewriteRuleSubtreeStream stream_expr=new RewriteRuleSubtreeStream(adaptor,"rule expr");
		try { DebugEnterRule(GrammarFileName, "program");
		DebugLocation(130, 32);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 24)) { return retval; }
			// MathLang.g:130:8: ( ( expr )* -> ^( BLOCK ( expr )* ) )
			DebugEnterAlt(1);
			// MathLang.g:130:10: ( expr )*
			{
			DebugLocation(130, 10);
			// MathLang.g:130:10: ( expr )*
			try { DebugEnterSubRule(21);
			while (true)
			{
				int alt21=2;
				try { DebugEnterDecision(21, decisionCanBacktrack[21]);
				int LA21_0 = input.LA(1);

				if (((LA21_0>=NIL && LA21_0<=QUOTE)||(LA21_0>=ATOM && LA21_0<=WORD)||LA21_0==33||(LA21_0>=35 && LA21_0<=36)))
				{
					alt21=1;
				}


				} finally { DebugExitDecision(21); }
				switch ( alt21 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:0:0: expr
					{
					DebugLocation(130, 10);
					PushFollow(Follow._expr_in_program1266);
					expr113=expr();
					PopFollow();
					if (state.failed) return retval;
					if ( state.backtracking == 0 ) stream_expr.Add(expr113.Tree);

					}
					break;

				default:
					goto loop21;
				}
			}

			loop21:
				;

			} finally { DebugExitSubRule(21); }



			{
			// AST REWRITE
			// elements: expr
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			if ( state.backtracking == 0 ) {
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 130:16: -> ^( BLOCK ( expr )* )
			{
				DebugLocation(130, 19);
				// MathLang.g:130:19: ^( BLOCK ( expr )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(130, 21);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(BLOCK, "BLOCK"), root_1);

				DebugLocation(130, 27);
				// MathLang.g:130:27: ( expr )*
				while ( stream_expr.HasNext )
				{
					DebugLocation(130, 27);
					adaptor.AddChild(root_1, stream_expr.NextTree());

				}
				stream_expr.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("program", 24);
			LeaveRule("program", 24);
			Leave_program();
			if (state.backtracking > 0) { Memoize(input, 24, program_StartIndex); }
		}
		DebugLocation(130, 32);
		} finally { DebugExitRule(GrammarFileName, "program"); }
		return retval;

	}
	// $ANTLR end "program"

	public class result_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_result();
	partial void Leave_result();

	// $ANTLR start "result"
	// MathLang.g:132:1: result : program EOF ;
	[GrammarRule("result")]
	private MathLangParser.result_return result()
	{
		Enter_result();
		EnterRule("result", 25);
		TraceIn("result", 25);
		MathLangParser.result_return retval = new MathLangParser.result_return();
		retval.Start = (IToken)input.LT(1);
		int result_StartIndex = input.Index;
		object root_0 = null;

		IToken EOF115=null;
		MathLangParser.program_return program114 = default(MathLangParser.program_return);

		object EOF115_tree=null;

		try { DebugEnterRule(GrammarFileName, "result");
		DebugLocation(132, 20);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 25)) { return retval; }
			// MathLang.g:132:7: ( program EOF )
			DebugEnterAlt(1);
			// MathLang.g:132:9: program EOF
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(132, 9);
			PushFollow(Follow._program_in_result1283);
			program114=program();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, program114.Tree);
			DebugLocation(132, 20);
			EOF115=(IToken)Match(input,EOF,Follow._EOF_in_result1285); if (state.failed) return retval;

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("result", 25);
			LeaveRule("result", 25);
			Leave_result();
			if (state.backtracking > 0) { Memoize(input, 25, result_StartIndex); }
		}
		DebugLocation(132, 20);
		} finally { DebugExitRule(GrammarFileName, "result"); }
		return retval;

	}
	// $ANTLR end "result"

	public class execute_return : ParserRuleReturnScope<IToken>, IAstRuleReturnScope<object>
	{
		private object _tree;
		public object Tree { get { return _tree; } set { _tree = value; } }
	}

	partial void Enter_execute();
	partial void Leave_execute();

	// $ANTLR start "execute"
	// MathLang.g:134:8: public execute : result ;
	[GrammarRule("execute")]
	public MathLangParser.execute_return execute()
	{
		Enter_execute();
		EnterRule("execute", 26);
		TraceIn("execute", 26);
		MathLangParser.execute_return retval = new MathLangParser.execute_return();
		retval.Start = (IToken)input.LT(1);
		int execute_StartIndex = input.Index;
		object root_0 = null;

		MathLangParser.result_return result116 = default(MathLangParser.result_return);


		try { DebugEnterRule(GrammarFileName, "execute");
		DebugLocation(134, 0);
		try
		{
			if (state.backtracking > 0 && AlreadyParsedRule(input, 26)) { return retval; }
			// MathLang.g:134:15: ( result )
			DebugEnterAlt(1);
			// MathLang.g:135:3: result
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(135, 3);
			PushFollow(Follow._result_in_execute1297);
			result116=result();
			PopFollow();
			if (state.failed) return retval;
			if ( state.backtracking == 0 ) adaptor.AddChild(root_0, result116.Tree);

			}

			retval.Stop = (IToken)input.LT(-1);

			if ( state.backtracking == 0 ) {

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);
			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("execute", 26);
			LeaveRule("execute", 26);
			Leave_execute();
			if (state.backtracking > 0) { Memoize(input, 26, execute_StartIndex); }
		}
		DebugLocation(136, 0);
		} finally { DebugExitRule(GrammarFileName, "execute"); }
		return retval;

	}
	// $ANTLR end "execute"

	partial void Enter_synpred23_MathLang_fragment();
	partial void Leave_synpred23_MathLang_fragment();

	// $ANTLR start synpred23_MathLang
	public void synpred23_MathLang_fragment()
	{
		Enter_synpred23_MathLang_fragment();
		EnterRule("synpred23_MathLang_fragment", 49);
		TraceIn("synpred23_MathLang_fragment", 49);
		try
		{
			// MathLang.g:89:16: ( ( '(' ( ATOM | WORD )+ ')' ) )
			DebugEnterAlt(1);
			// MathLang.g:89:16: ( '(' ( ATOM | WORD )+ ')' )
			{
			DebugLocation(89, 16);
			// MathLang.g:89:16: ( '(' ( ATOM | WORD )+ ')' )
			DebugEnterAlt(1);
			// MathLang.g:89:18: '(' ( ATOM | WORD )+ ')'
			{
			DebugLocation(89, 18);
			Match(input,33,Follow._33_in_synpred23_MathLang869); if (state.failed) return;
			DebugLocation(89, 23);
			// MathLang.g:89:23: ( ATOM | WORD )+
			int cnt23=0;
			try { DebugEnterSubRule(23);
			while (true)
			{
				int alt23=2;
				try { DebugEnterDecision(23, decisionCanBacktrack[23]);
				int LA23_0 = input.LA(1);

				if (((LA23_0>=ATOM && LA23_0<=WORD)))
				{
					alt23=1;
				}


				} finally { DebugExitDecision(23); }
				switch (alt23)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:
					{
					DebugLocation(89, 23);
					if ((input.LA(1)>=ATOM && input.LA(1)<=WORD))
					{
						input.Consume();
						state.errorRecovery=false;state.failed=false;
					}
					else
					{
						if (state.backtracking>0) {state.failed=true; return;}
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}


					}
					break;

				default:
					if (cnt23 >= 1)
						goto loop23;

					if (state.backtracking>0) {state.failed=true; return;}
					EarlyExitException eee23 = new EarlyExitException( 23, input );
					DebugRecognitionException(eee23);
					throw eee23;
				}
				cnt23++;
			}
			loop23:
				;

			} finally { DebugExitSubRule(23); }

			DebugLocation(89, 38);
			Match(input,34,Follow._34_in_synpred23_MathLang881); if (state.failed) return;

			}


			}

		}
		finally
		{
			TraceOut("synpred23_MathLang_fragment", 49);
			LeaveRule("synpred23_MathLang_fragment", 49);
			Leave_synpred23_MathLang_fragment();
		}
	}
	// $ANTLR end synpred23_MathLang

	partial void Enter_synpred31_MathLang_fragment();
	partial void Leave_synpred31_MathLang_fragment();

	// $ANTLR start synpred31_MathLang
	public void synpred31_MathLang_fragment()
	{
		Enter_synpred31_MathLang_fragment();
		EnterRule("synpred31_MathLang_fragment", 57);
		TraceIn("synpred31_MathLang_fragment", 57);
		try
		{
			// MathLang.g:94:15: ( argumentListLike )
			DebugEnterAlt(1);
			// MathLang.g:94:15: argumentListLike
			{
			DebugLocation(94, 15);
			PushFollow(Follow._argumentListLike_in_synpred31_MathLang962);
			argumentListLike();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred31_MathLang_fragment", 57);
			LeaveRule("synpred31_MathLang_fragment", 57);
			Leave_synpred31_MathLang_fragment();
		}
	}
	// $ANTLR end synpred31_MathLang

	partial void Enter_synpred38_MathLang_fragment();
	partial void Leave_synpred38_MathLang_fragment();

	// $ANTLR start synpred38_MathLang
	public void synpred38_MathLang_fragment()
	{
		Enter_synpred38_MathLang_fragment();
		EnterRule("synpred38_MathLang_fragment", 64);
		TraceIn("synpred38_MathLang_fragment", 64);
		try
		{
			// MathLang.g:112:3: ( group )
			DebugEnterAlt(1);
			// MathLang.g:112:3: group
			{
			DebugLocation(112, 3);
			PushFollow(Follow._group_in_synpred38_MathLang1192);
			group();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred38_MathLang_fragment", 64);
			LeaveRule("synpred38_MathLang_fragment", 64);
			Leave_synpred38_MathLang_fragment();
		}
	}
	// $ANTLR end synpred38_MathLang

	partial void Enter_synpred39_MathLang_fragment();
	partial void Leave_synpred39_MathLang_fragment();

	// $ANTLR start synpred39_MathLang
	public void synpred39_MathLang_fragment()
	{
		Enter_synpred39_MathLang_fragment();
		EnterRule("synpred39_MathLang_fragment", 65);
		TraceIn("synpred39_MathLang_fragment", 65);
		try
		{
			// MathLang.g:113:3: ( dotPair )
			DebugEnterAlt(1);
			// MathLang.g:113:3: dotPair
			{
			DebugLocation(113, 3);
			PushFollow(Follow._dotPair_in_synpred39_MathLang1196);
			dotPair();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred39_MathLang_fragment", 65);
			LeaveRule("synpred39_MathLang_fragment", 65);
			Leave_synpred39_MathLang_fragment();
		}
	}
	// $ANTLR end synpred39_MathLang

	partial void Enter_synpred42_MathLang_fragment();
	partial void Leave_synpred42_MathLang_fragment();

	// $ANTLR start synpred42_MathLang
	public void synpred42_MathLang_fragment()
	{
		Enter_synpred42_MathLang_fragment();
		EnterRule("synpred42_MathLang_fragment", 68);
		TraceIn("synpred42_MathLang_fragment", 68);
		try
		{
			// MathLang.g:116:3: ( car )
			DebugEnterAlt(1);
			// MathLang.g:116:3: car
			{
			DebugLocation(116, 3);
			PushFollow(Follow._car_in_synpred42_MathLang1214);
			car();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred42_MathLang_fragment", 68);
			LeaveRule("synpred42_MathLang_fragment", 68);
			Leave_synpred42_MathLang_fragment();
		}
	}
	// $ANTLR end synpred42_MathLang

	partial void Enter_synpred43_MathLang_fragment();
	partial void Leave_synpred43_MathLang_fragment();

	// $ANTLR start synpred43_MathLang
	public void synpred43_MathLang_fragment()
	{
		Enter_synpred43_MathLang_fragment();
		EnterRule("synpred43_MathLang_fragment", 69);
		TraceIn("synpred43_MathLang_fragment", 69);
		try
		{
			// MathLang.g:117:3: ( cdr )
			DebugEnterAlt(1);
			// MathLang.g:117:3: cdr
			{
			DebugLocation(117, 3);
			PushFollow(Follow._cdr_in_synpred43_MathLang1218);
			cdr();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred43_MathLang_fragment", 69);
			LeaveRule("synpred43_MathLang_fragment", 69);
			Leave_synpred43_MathLang_fragment();
		}
	}
	// $ANTLR end synpred43_MathLang

	partial void Enter_synpred44_MathLang_fragment();
	partial void Leave_synpred44_MathLang_fragment();

	// $ANTLR start synpred44_MathLang
	public void synpred44_MathLang_fragment()
	{
		Enter_synpred44_MathLang_fragment();
		EnterRule("synpred44_MathLang_fragment", 70);
		TraceIn("synpred44_MathLang_fragment", 70);
		try
		{
			// MathLang.g:118:3: ( cons )
			DebugEnterAlt(1);
			// MathLang.g:118:3: cons
			{
			DebugLocation(118, 3);
			PushFollow(Follow._cons_in_synpred44_MathLang1222);
			cons();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred44_MathLang_fragment", 70);
			LeaveRule("synpred44_MathLang_fragment", 70);
			Leave_synpred44_MathLang_fragment();
		}
	}
	// $ANTLR end synpred44_MathLang

	partial void Enter_synpred45_MathLang_fragment();
	partial void Leave_synpred45_MathLang_fragment();

	// $ANTLR start synpred45_MathLang
	public void synpred45_MathLang_fragment()
	{
		Enter_synpred45_MathLang_fragment();
		EnterRule("synpred45_MathLang_fragment", 71);
		TraceIn("synpred45_MathLang_fragment", 71);
		try
		{
			// MathLang.g:119:3: ( eq )
			DebugEnterAlt(1);
			// MathLang.g:119:3: eq
			{
			DebugLocation(119, 3);
			PushFollow(Follow._eq_in_synpred45_MathLang1226);
			eq();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred45_MathLang_fragment", 71);
			LeaveRule("synpred45_MathLang_fragment", 71);
			Leave_synpred45_MathLang_fragment();
		}
	}
	// $ANTLR end synpred45_MathLang

	partial void Enter_synpred46_MathLang_fragment();
	partial void Leave_synpred46_MathLang_fragment();

	// $ANTLR start synpred46_MathLang
	public void synpred46_MathLang_fragment()
	{
		Enter_synpred46_MathLang_fragment();
		EnterRule("synpred46_MathLang_fragment", 72);
		TraceIn("synpred46_MathLang_fragment", 72);
		try
		{
			// MathLang.g:120:3: ( nil )
			DebugEnterAlt(1);
			// MathLang.g:120:3: nil
			{
			DebugLocation(120, 3);
			PushFollow(Follow._nil_in_synpred46_MathLang1230);
			nil();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred46_MathLang_fragment", 72);
			LeaveRule("synpred46_MathLang_fragment", 72);
			Leave_synpred46_MathLang_fragment();
		}
	}
	// $ANTLR end synpred46_MathLang

	partial void Enter_synpred47_MathLang_fragment();
	partial void Leave_synpred47_MathLang_fragment();

	// $ANTLR start synpred47_MathLang
	public void synpred47_MathLang_fragment()
	{
		Enter_synpred47_MathLang_fragment();
		EnterRule("synpred47_MathLang_fragment", 73);
		TraceIn("synpred47_MathLang_fragment", 73);
		try
		{
			// MathLang.g:121:3: ( nil2 )
			DebugEnterAlt(1);
			// MathLang.g:121:3: nil2
			{
			DebugLocation(121, 3);
			PushFollow(Follow._nil2_in_synpred47_MathLang1234);
			nil2();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred47_MathLang_fragment", 73);
			LeaveRule("synpred47_MathLang_fragment", 73);
			Leave_synpred47_MathLang_fragment();
		}
	}
	// $ANTLR end synpred47_MathLang

	partial void Enter_synpred48_MathLang_fragment();
	partial void Leave_synpred48_MathLang_fragment();

	// $ANTLR start synpred48_MathLang
	public void synpred48_MathLang_fragment()
	{
		Enter_synpred48_MathLang_fragment();
		EnterRule("synpred48_MathLang_fragment", 74);
		TraceIn("synpred48_MathLang_fragment", 74);
		try
		{
			// MathLang.g:122:3: ( nuLL )
			DebugEnterAlt(1);
			// MathLang.g:122:3: nuLL
			{
			DebugLocation(122, 3);
			PushFollow(Follow._nuLL_in_synpred48_MathLang1238);
			nuLL();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred48_MathLang_fragment", 74);
			LeaveRule("synpred48_MathLang_fragment", 74);
			Leave_synpred48_MathLang_fragment();
		}
	}
	// $ANTLR end synpred48_MathLang

	partial void Enter_synpred49_MathLang_fragment();
	partial void Leave_synpred49_MathLang_fragment();

	// $ANTLR start synpred49_MathLang
	public void synpred49_MathLang_fragment()
	{
		Enter_synpred49_MathLang_fragment();
		EnterRule("synpred49_MathLang_fragment", 75);
		TraceIn("synpred49_MathLang_fragment", 75);
		try
		{
			// MathLang.g:123:3: ( assign )
			DebugEnterAlt(1);
			// MathLang.g:123:3: assign
			{
			DebugLocation(123, 3);
			PushFollow(Follow._assign_in_synpred49_MathLang1242);
			assign();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred49_MathLang_fragment", 75);
			LeaveRule("synpred49_MathLang_fragment", 75);
			Leave_synpred49_MathLang_fragment();
		}
	}
	// $ANTLR end synpred49_MathLang

	partial void Enter_synpred50_MathLang_fragment();
	partial void Leave_synpred50_MathLang_fragment();

	// $ANTLR start synpred50_MathLang
	public void synpred50_MathLang_fragment()
	{
		Enter_synpred50_MathLang_fragment();
		EnterRule("synpred50_MathLang_fragment", 76);
		TraceIn("synpred50_MathLang_fragment", 76);
		try
		{
			// MathLang.g:124:3: ( fun )
			DebugEnterAlt(1);
			// MathLang.g:124:3: fun
			{
			DebugLocation(124, 3);
			PushFollow(Follow._fun_in_synpred50_MathLang1246);
			fun();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred50_MathLang_fragment", 76);
			LeaveRule("synpred50_MathLang_fragment", 76);
			Leave_synpred50_MathLang_fragment();
		}
	}
	// $ANTLR end synpred50_MathLang

	partial void Enter_synpred51_MathLang_fragment();
	partial void Leave_synpred51_MathLang_fragment();

	// $ANTLR start synpred51_MathLang
	public void synpred51_MathLang_fragment()
	{
		Enter_synpred51_MathLang_fragment();
		EnterRule("synpred51_MathLang_fragment", 77);
		TraceIn("synpred51_MathLang_fragment", 77);
		try
		{
			// MathLang.g:125:3: ( methodExe )
			DebugEnterAlt(1);
			// MathLang.g:125:3: methodExe
			{
			DebugLocation(125, 3);
			PushFollow(Follow._methodExe_in_synpred51_MathLang1250);
			methodExe();
			PopFollow();
			if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred51_MathLang_fragment", 77);
			LeaveRule("synpred51_MathLang_fragment", 77);
			Leave_synpred51_MathLang_fragment();
		}
	}
	// $ANTLR end synpred51_MathLang

	partial void Enter_synpred52_MathLang_fragment();
	partial void Leave_synpred52_MathLang_fragment();

	// $ANTLR start synpred52_MathLang
	public void synpred52_MathLang_fragment()
	{
		Enter_synpred52_MathLang_fragment();
		EnterRule("synpred52_MathLang_fragment", 78);
		TraceIn("synpred52_MathLang_fragment", 78);
		try
		{
			// MathLang.g:126:3: ( WORD )
			DebugEnterAlt(1);
			// MathLang.g:126:3: WORD
			{
			DebugLocation(126, 3);
			Match(input,WORD,Follow._WORD_in_synpred52_MathLang1254); if (state.failed) return;

			}

		}
		finally
		{
			TraceOut("synpred52_MathLang_fragment", 78);
			LeaveRule("synpred52_MathLang_fragment", 78);
			Leave_synpred52_MathLang_fragment();
		}
	}
	// $ANTLR end synpred52_MathLang
	#endregion Rules

	#region Synpreds
	private bool EvaluatePredicate(System.Action fragment)
	{
		bool success = false;
		state.backtracking++;
		try { DebugBeginBacktrack(state.backtracking);
		int start = input.Mark();
		try
		{
			fragment();
		}
		catch ( RecognitionException re )
		{
			System.Console.Error.WriteLine("impossible: "+re);
		}
		success = !state.failed;
		input.Rewind(start);
		} finally { DebugEndBacktrack(state.backtracking, success); }
		state.backtracking--;
		state.failed=false;
		return success;
	}
	#endregion Synpreds


	#region DFA
	DFA20 dfa20;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa20 = new DFA20( this, SpecialStateTransition20 );
	}

	private class DFA20 : DFA
	{
		private const string DFA20_eotS =
			"\x15\xFFFF";
		private const string DFA20_eofS =
			"\x15\xFFFF";
		private const string DFA20_minS =
			"\x1\x5\x1\x0\x1\xFFFF\x2\x0\x2\xFFFF\x1\x0\xD\xFFFF";
		private const string DFA20_maxS =
			"\x1\x24\x1\x0\x1\xFFFF\x2\x0\x2\xFFFF\x1\x0\xD\xFFFF";
		private const string DFA20_acceptS =
			"\x2\xFFFF\x1\x1\x2\xFFFF\x1\x3\x1\x4\x1\xFFFF\x1\x2\x1\x5\x1\x6\x1\x7"+
			"\x1\x8\x1\xB\x1\xD\x1\xE\x1\x10\x1\x9\x1\xA\x1\xC\x1\xF";
		private const string DFA20_specialS =
			"\x1\xFFFF\x1\x0\x1\xFFFF\x1\x1\x1\x2\x2\xFFFF\x1\x3\xD\xFFFF}>";
		private static readonly string[] DFA20_transitionS =
			{
				"\x1\x3\x1\x6\xC\xFFFF\x1\x2\x1\x7\xC\xFFFF\x1\x1\x1\xFFFF\x1\x4\x1"+
				"\x5",
				"\x1\xFFFF",
				"",
				"\x1\xFFFF",
				"\x1\xFFFF",
				"",
				"",
				"\x1\xFFFF",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				"",
				""
			};

		private static readonly short[] DFA20_eot = DFA.UnpackEncodedString(DFA20_eotS);
		private static readonly short[] DFA20_eof = DFA.UnpackEncodedString(DFA20_eofS);
		private static readonly char[] DFA20_min = DFA.UnpackEncodedStringToUnsignedChars(DFA20_minS);
		private static readonly char[] DFA20_max = DFA.UnpackEncodedStringToUnsignedChars(DFA20_maxS);
		private static readonly short[] DFA20_accept = DFA.UnpackEncodedString(DFA20_acceptS);
		private static readonly short[] DFA20_special = DFA.UnpackEncodedString(DFA20_specialS);
		private static readonly short[][] DFA20_transition;

		static DFA20()
		{
			int numStates = DFA20_transitionS.Length;
			DFA20_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA20_transition[i] = DFA.UnpackEncodedString(DFA20_transitionS[i]);
			}
		}

		public DFA20( BaseRecognizer recognizer, SpecialStateTransitionHandler specialStateTransition )
			: base(specialStateTransition)
		{
			this.recognizer = recognizer;
			this.decisionNumber = 20;
			this.eot = DFA20_eot;
			this.eof = DFA20_eof;
			this.min = DFA20_min;
			this.max = DFA20_max;
			this.accept = DFA20_accept;
			this.special = DFA20_special;
			this.transition = DFA20_transition;
		}

		public override string Description { get { return "111:1: expr : ( group | dotPair | '\"' WORD '\"' | list | car | cdr | cons | eq | nil | nil2 | nuLL | assign | fun | methodExe | WORD | myif );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

	private int SpecialStateTransition20(DFA dfa, int s, IIntStream _input)
	{
		ITokenStream input = (ITokenStream)_input;
		int _s = s;
		switch (s)
		{
			case 0:
				int LA20_1 = input.LA(1);


				int index20_1 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred38_MathLang_fragment)) ) {s = 2;}

				else if ( (EvaluatePredicate(synpred39_MathLang_fragment)) ) {s = 8;}

				else if ( (EvaluatePredicate(synpred42_MathLang_fragment)) ) {s = 9;}

				else if ( (EvaluatePredicate(synpred43_MathLang_fragment)) ) {s = 10;}

				else if ( (EvaluatePredicate(synpred44_MathLang_fragment)) ) {s = 11;}

				else if ( (EvaluatePredicate(synpred45_MathLang_fragment)) ) {s = 12;}

				else if ( (EvaluatePredicate(synpred48_MathLang_fragment)) ) {s = 13;}

				else if ( (EvaluatePredicate(synpred50_MathLang_fragment)) ) {s = 14;}

				else if ( (EvaluatePredicate(synpred51_MathLang_fragment)) ) {s = 15;}

				else if ( (true) ) {s = 16;}


				input.Seek(index20_1);
				if ( s>=0 ) return s;
				break;
			case 1:
				int LA20_3 = input.LA(1);


				int index20_3 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred38_MathLang_fragment)) ) {s = 2;}

				else if ( (EvaluatePredicate(synpred46_MathLang_fragment)) ) {s = 17;}


				input.Seek(index20_3);
				if ( s>=0 ) return s;
				break;
			case 2:
				int LA20_4 = input.LA(1);


				int index20_4 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred38_MathLang_fragment)) ) {s = 2;}

				else if ( (EvaluatePredicate(synpred47_MathLang_fragment)) ) {s = 18;}


				input.Seek(index20_4);
				if ( s>=0 ) return s;
				break;
			case 3:
				int LA20_7 = input.LA(1);


				int index20_7 = input.Index;
				input.Rewind();
				s = -1;
				if ( (EvaluatePredicate(synpred49_MathLang_fragment)) ) {s = 19;}

				else if ( (EvaluatePredicate(synpred52_MathLang_fragment)) ) {s = 20;}


				input.Seek(index20_7);
				if ( s>=0 ) return s;
				break;
		}
		if (state.backtracking > 0) {state.failed=true; return -1;}
		NoViableAltException nvae = new NoViableAltException(dfa.Description, 20, _s, input);
		dfa.Error(nvae);
		throw nvae;
	}

	#endregion DFA

	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _33_in_group615 = new BitSet(new ulong[]{0xAFFD80020UL});
		public static readonly BitSet _term_in_group618 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _34_in_group620 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _ATOM_in_group627 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _nil_in_group633 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _nil2_in_group639 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodExe_in_group645 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_mult654 = new BitSet(new ulong[]{0xA00180020UL});
		public static readonly BitSet _group_in_mult666 = new BitSet(new ulong[]{0xA00180020UL});
		public static readonly BitSet _WORD_in_mult670 = new BitSet(new ulong[]{0xA00180020UL});
		public static readonly BitSet _group_in_mult676 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WORD_in_mult680 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_add692 = new BitSet(new ulong[]{0xAFFD80020UL});
		public static readonly BitSet _mult_in_add703 = new BitSet(new ulong[]{0xAFFD80020UL});
		public static readonly BitSet _mult_in_add707 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _set_in_compare721 = new BitSet(new ulong[]{0xAFFD80020UL});
		public static readonly BitSet _add_in_compare747 = new BitSet(new ulong[]{0xAFFD80020UL});
		public static readonly BitSet _add_in_compare751 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _compare_in_term759 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _33_in_dotPair769 = new BitSet(new ulong[]{0x200080020UL});
		public static readonly BitSet _ATOM_in_dotPair773 = new BitSet(new ulong[]{0x100000000UL});
		public static readonly BitSet _dotPair_in_dotPair777 = new BitSet(new ulong[]{0x100000000UL});
		public static readonly BitSet _NIL_in_dotPair781 = new BitSet(new ulong[]{0x100000000UL});
		public static readonly BitSet _DOT_in_dotPair784 = new BitSet(new ulong[]{0x200080020UL});
		public static readonly BitSet _ATOM_in_dotPair788 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _dotPair_in_dotPair792 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _NIL_in_dotPair796 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _34_in_dotPair799 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NIL_in_nil845 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _35_in_nil2851 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _QUOTE_in_list863 = new BitSet(new ulong[]{0xA00180020UL});
		public static readonly BitSet _33_in_list869 = new BitSet(new ulong[]{0x180000UL});
		public static readonly BitSet _set_in_list872 = new BitSet(new ulong[]{0x400180000UL});
		public static readonly BitSet _34_in_list881 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _group_in_list889 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WORD_in_list893 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _list_in_argumentListLike905 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _nil_in_argumentListLike909 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _cdr_in_argumentListLike913 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _cons_in_argumentListLike917 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _nil2_in_argumentListLike921 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _QUOTE_in_argumentATOMLike934 = new BitSet(new ulong[]{0x180000UL});
		public static readonly BitSet _set_in_argumentATOMLike937 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _car_in_argumentATOMLike948 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _argumentListLike_in_allArguments962 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _argumentATOMLike_in_allArguments966 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _33_in_car979 = new BitSet(new ulong[]{0x80UL});
		public static readonly BitSet _CAR_in_car982 = new BitSet(new ulong[]{0xA00000060UL});
		public static readonly BitSet _allArguments_in_car985 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _34_in_car987 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _33_in_cdr1001 = new BitSet(new ulong[]{0x100UL});
		public static readonly BitSet _CDR_in_cdr1004 = new BitSet(new ulong[]{0xA00000060UL});
		public static readonly BitSet _allArguments_in_cdr1007 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _34_in_cdr1009 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _33_in_cons1022 = new BitSet(new ulong[]{0x200UL});
		public static readonly BitSet _CONS_in_cons1025 = new BitSet(new ulong[]{0xA00000060UL});
		public static readonly BitSet _allArguments_in_cons1028 = new BitSet(new ulong[]{0xA00000060UL});
		public static readonly BitSet _allArguments_in_cons1030 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _34_in_cons1032 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _33_in_eq1042 = new BitSet(new ulong[]{0x400UL});
		public static readonly BitSet _EQUAL_in_eq1045 = new BitSet(new ulong[]{0xA00000060UL});
		public static readonly BitSet _allArguments_in_eq1050 = new BitSet(new ulong[]{0xA00000060UL});
		public static readonly BitSet _allArguments_in_eq1052 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _34_in_eq1055 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _33_in_nuLL1063 = new BitSet(new ulong[]{0x10UL});
		public static readonly BitSet _NULL_in_nuLL1066 = new BitSet(new ulong[]{0xA00000060UL});
		public static readonly BitSet _allArguments_in_nuLL1069 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _34_in_nuLL1071 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WORD_in_assign1084 = new BitSet(new ulong[]{0x1000UL});
		public static readonly BitSet _ASSIGN_in_assign1086 = new BitSet(new ulong[]{0xA00180020UL});
		public static readonly BitSet _group_in_assign1090 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WORD_in_assign1094 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WORD_in_methodSignature1102 = new BitSet(new ulong[]{0x200000000UL});
		public static readonly BitSet _33_in_methodSignature1105 = new BitSet(new ulong[]{0x400100000UL});
		public static readonly BitSet _WORD_in_methodSignature1108 = new BitSet(new ulong[]{0x400100000UL});
		public static readonly BitSet _34_in_methodSignature1111 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _33_in_fun1119 = new BitSet(new ulong[]{0x800UL});
		public static readonly BitSet _DEFUN_in_fun1122 = new BitSet(new ulong[]{0x100000UL});
		public static readonly BitSet _methodSignature_in_fun1125 = new BitSet(new ulong[]{0x1E00180060UL});
		public static readonly BitSet _expr_in_fun1127 = new BitSet(new ulong[]{0x1E00180060UL});
		public static readonly BitSet _34_in_fun1130 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _33_in_methodExe1139 = new BitSet(new ulong[]{0x100000UL});
		public static readonly BitSet _WORD_in_methodExe1142 = new BitSet(new ulong[]{0x200000000UL});
		public static readonly BitSet _33_in_methodExe1145 = new BitSet(new ulong[]{0xE00180020UL});
		public static readonly BitSet _group_in_methodExe1149 = new BitSet(new ulong[]{0xE00180020UL});
		public static readonly BitSet _WORD_in_methodExe1153 = new BitSet(new ulong[]{0xE00180020UL});
		public static readonly BitSet _34_in_methodExe1157 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _34_in_methodExe1160 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _33_in_myif1168 = new BitSet(new ulong[]{0x2000UL});
		public static readonly BitSet _IF_in_myif1171 = new BitSet(new ulong[]{0xAFFD80020UL});
		public static readonly BitSet _compare_in_myif1174 = new BitSet(new ulong[]{0x1A00180060UL});
		public static readonly BitSet _expr_in_myif1176 = new BitSet(new ulong[]{0x1E00180060UL});
		public static readonly BitSet _expr_in_myif1178 = new BitSet(new ulong[]{0x400000000UL});
		public static readonly BitSet _34_in_myif1181 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _group_in_expr1192 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _dotPair_in_expr1196 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _36_in_expr1200 = new BitSet(new ulong[]{0x100000UL});
		public static readonly BitSet _WORD_in_expr1203 = new BitSet(new ulong[]{0x1000000000UL});
		public static readonly BitSet _36_in_expr1205 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _list_in_expr1210 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _car_in_expr1214 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _cdr_in_expr1218 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _cons_in_expr1222 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _eq_in_expr1226 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _nil_in_expr1230 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _nil2_in_expr1234 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _nuLL_in_expr1238 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assign_in_expr1242 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _fun_in_expr1246 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodExe_in_expr1250 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WORD_in_expr1254 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _myif_in_expr1258 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _expr_in_program1266 = new BitSet(new ulong[]{0x1A00180062UL});
		public static readonly BitSet _program_in_result1283 = new BitSet(new ulong[]{0x0UL});
		public static readonly BitSet _EOF_in_result1285 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _result_in_execute1297 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _33_in_synpred23_MathLang869 = new BitSet(new ulong[]{0x180000UL});
		public static readonly BitSet _set_in_synpred23_MathLang872 = new BitSet(new ulong[]{0x400180000UL});
		public static readonly BitSet _34_in_synpred23_MathLang881 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _argumentListLike_in_synpred31_MathLang962 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _group_in_synpred38_MathLang1192 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _dotPair_in_synpred39_MathLang1196 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _car_in_synpred42_MathLang1214 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _cdr_in_synpred43_MathLang1218 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _cons_in_synpred44_MathLang1222 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _eq_in_synpred45_MathLang1226 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _nil_in_synpred46_MathLang1230 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _nil2_in_synpred47_MathLang1234 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _nuLL_in_synpred48_MathLang1238 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assign_in_synpred49_MathLang1242 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _fun_in_synpred50_MathLang1246 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _methodExe_in_synpred51_MathLang1250 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _WORD_in_synpred52_MathLang1254 = new BitSet(new ulong[]{0x2UL});

	}
	#endregion Follow sets
}

} // namespace  MathLang 
