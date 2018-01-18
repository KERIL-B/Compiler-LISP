// $ANTLR 3.3 Nov 30, 2010 12:50:56 MathLang.g 2018-01-18 00:23:59

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162


using System.Collections.Generic;
using Antlr.Runtime;
using Stack = System.Collections.Generic.Stack<object>;
using List = System.Collections.IList;
using ArrayList = System.Collections.Generic.List<object>;

namespace  MathLang 
{
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.3 Nov 30, 2010 12:50:56")]
[System.CLSCompliant(false)]
public partial class MathLangLexer : Antlr.Runtime.Lexer
{
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

	public MathLangLexer()
	{
		OnCreated();
	}

	public MathLangLexer(ICharStream input )
		: this(input, new RecognizerSharedState())
	{
	}

	public MathLangLexer(ICharStream input, RecognizerSharedState state)
		: base(input, state)
	{


		OnCreated();
	}
	public override string GrammarFileName { get { return "MathLang.g"; } }

	private static readonly bool[] decisionCanBacktrack = new bool[0];


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	partial void Enter_NULL();
	partial void Leave_NULL();

	// $ANTLR start "NULL"
	[GrammarRule("NULL")]
	private void mNULL()
	{
		Enter_NULL();
		EnterRule("NULL", 1);
		TraceIn("NULL", 1);
		try
		{
			int _type = NULL;
			int _channel = DefaultTokenChannel;
			// MathLang.g:9:6: ( 'null' )
			DebugEnterAlt(1);
			// MathLang.g:9:8: 'null'
			{
			DebugLocation(9, 8);
			Match("null"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NULL", 1);
			LeaveRule("NULL", 1);
			Leave_NULL();
		}
	}
	// $ANTLR end "NULL"

	partial void Enter_NIL();
	partial void Leave_NIL();

	// $ANTLR start "NIL"
	[GrammarRule("NIL")]
	private void mNIL()
	{
		Enter_NIL();
		EnterRule("NIL", 2);
		TraceIn("NIL", 2);
		try
		{
			int _type = NIL;
			int _channel = DefaultTokenChannel;
			// MathLang.g:10:5: ( 'nil' )
			DebugEnterAlt(1);
			// MathLang.g:10:7: 'nil'
			{
			DebugLocation(10, 7);
			Match("nil"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NIL", 2);
			LeaveRule("NIL", 2);
			Leave_NIL();
		}
	}
	// $ANTLR end "NIL"

	partial void Enter_QUOTE();
	partial void Leave_QUOTE();

	// $ANTLR start "QUOTE"
	[GrammarRule("QUOTE")]
	private void mQUOTE()
	{
		Enter_QUOTE();
		EnterRule("QUOTE", 3);
		TraceIn("QUOTE", 3);
		try
		{
			int _type = QUOTE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:11:7: ( '\\'' )
			DebugEnterAlt(1);
			// MathLang.g:11:9: '\\''
			{
			DebugLocation(11, 9);
			Match('\''); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("QUOTE", 3);
			LeaveRule("QUOTE", 3);
			Leave_QUOTE();
		}
	}
	// $ANTLR end "QUOTE"

	partial void Enter_CAR();
	partial void Leave_CAR();

	// $ANTLR start "CAR"
	[GrammarRule("CAR")]
	private void mCAR()
	{
		Enter_CAR();
		EnterRule("CAR", 4);
		TraceIn("CAR", 4);
		try
		{
			int _type = CAR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:12:5: ( 'car' )
			DebugEnterAlt(1);
			// MathLang.g:12:7: 'car'
			{
			DebugLocation(12, 7);
			Match("car"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CAR", 4);
			LeaveRule("CAR", 4);
			Leave_CAR();
		}
	}
	// $ANTLR end "CAR"

	partial void Enter_CDR();
	partial void Leave_CDR();

	// $ANTLR start "CDR"
	[GrammarRule("CDR")]
	private void mCDR()
	{
		Enter_CDR();
		EnterRule("CDR", 5);
		TraceIn("CDR", 5);
		try
		{
			int _type = CDR;
			int _channel = DefaultTokenChannel;
			// MathLang.g:13:5: ( 'cdr' )
			DebugEnterAlt(1);
			// MathLang.g:13:7: 'cdr'
			{
			DebugLocation(13, 7);
			Match("cdr"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CDR", 5);
			LeaveRule("CDR", 5);
			Leave_CDR();
		}
	}
	// $ANTLR end "CDR"

	partial void Enter_CONS();
	partial void Leave_CONS();

	// $ANTLR start "CONS"
	[GrammarRule("CONS")]
	private void mCONS()
	{
		Enter_CONS();
		EnterRule("CONS", 6);
		TraceIn("CONS", 6);
		try
		{
			int _type = CONS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:14:6: ( 'cons' )
			DebugEnterAlt(1);
			// MathLang.g:14:8: 'cons'
			{
			DebugLocation(14, 8);
			Match("cons"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("CONS", 6);
			LeaveRule("CONS", 6);
			Leave_CONS();
		}
	}
	// $ANTLR end "CONS"

	partial void Enter_EQUAL();
	partial void Leave_EQUAL();

	// $ANTLR start "EQUAL"
	[GrammarRule("EQUAL")]
	private void mEQUAL()
	{
		Enter_EQUAL();
		EnterRule("EQUAL", 7);
		TraceIn("EQUAL", 7);
		try
		{
			int _type = EQUAL;
			int _channel = DefaultTokenChannel;
			// MathLang.g:15:7: ( 'equal' )
			DebugEnterAlt(1);
			// MathLang.g:15:9: 'equal'
			{
			DebugLocation(15, 9);
			Match("equal"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EQUAL", 7);
			LeaveRule("EQUAL", 7);
			Leave_EQUAL();
		}
	}
	// $ANTLR end "EQUAL"

	partial void Enter_DEFUN();
	partial void Leave_DEFUN();

	// $ANTLR start "DEFUN"
	[GrammarRule("DEFUN")]
	private void mDEFUN()
	{
		Enter_DEFUN();
		EnterRule("DEFUN", 8);
		TraceIn("DEFUN", 8);
		try
		{
			int _type = DEFUN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:16:7: ( 'defun' )
			DebugEnterAlt(1);
			// MathLang.g:16:9: 'defun'
			{
			DebugLocation(16, 9);
			Match("defun"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DEFUN", 8);
			LeaveRule("DEFUN", 8);
			Leave_DEFUN();
		}
	}
	// $ANTLR end "DEFUN"

	partial void Enter_ASSIGN();
	partial void Leave_ASSIGN();

	// $ANTLR start "ASSIGN"
	[GrammarRule("ASSIGN")]
	private void mASSIGN()
	{
		Enter_ASSIGN();
		EnterRule("ASSIGN", 9);
		TraceIn("ASSIGN", 9);
		try
		{
			int _type = ASSIGN;
			int _channel = DefaultTokenChannel;
			// MathLang.g:17:8: ( '::=' )
			DebugEnterAlt(1);
			// MathLang.g:17:10: '::='
			{
			DebugLocation(17, 10);
			Match("::="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ASSIGN", 9);
			LeaveRule("ASSIGN", 9);
			Leave_ASSIGN();
		}
	}
	// $ANTLR end "ASSIGN"

	partial void Enter_IF();
	partial void Leave_IF();

	// $ANTLR start "IF"
	[GrammarRule("IF")]
	private void mIF()
	{
		Enter_IF();
		EnterRule("IF", 10);
		TraceIn("IF", 10);
		try
		{
			int _type = IF;
			int _channel = DefaultTokenChannel;
			// MathLang.g:18:4: ( 'if' )
			DebugEnterAlt(1);
			// MathLang.g:18:6: 'if'
			{
			DebugLocation(18, 6);
			Match("if"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("IF", 10);
			LeaveRule("IF", 10);
			Leave_IF();
		}
	}
	// $ANTLR end "IF"

	partial void Enter_T__33();
	partial void Leave_T__33();

	// $ANTLR start "T__33"
	[GrammarRule("T__33")]
	private void mT__33()
	{
		Enter_T__33();
		EnterRule("T__33", 11);
		TraceIn("T__33", 11);
		try
		{
			int _type = T__33;
			int _channel = DefaultTokenChannel;
			// MathLang.g:19:7: ( '(' )
			DebugEnterAlt(1);
			// MathLang.g:19:9: '('
			{
			DebugLocation(19, 9);
			Match('('); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__33", 11);
			LeaveRule("T__33", 11);
			Leave_T__33();
		}
	}
	// $ANTLR end "T__33"

	partial void Enter_T__34();
	partial void Leave_T__34();

	// $ANTLR start "T__34"
	[GrammarRule("T__34")]
	private void mT__34()
	{
		Enter_T__34();
		EnterRule("T__34", 12);
		TraceIn("T__34", 12);
		try
		{
			int _type = T__34;
			int _channel = DefaultTokenChannel;
			// MathLang.g:20:7: ( ')' )
			DebugEnterAlt(1);
			// MathLang.g:20:9: ')'
			{
			DebugLocation(20, 9);
			Match(')'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__34", 12);
			LeaveRule("T__34", 12);
			Leave_T__34();
		}
	}
	// $ANTLR end "T__34"

	partial void Enter_T__35();
	partial void Leave_T__35();

	// $ANTLR start "T__35"
	[GrammarRule("T__35")]
	private void mT__35()
	{
		Enter_T__35();
		EnterRule("T__35", 13);
		TraceIn("T__35", 13);
		try
		{
			int _type = T__35;
			int _channel = DefaultTokenChannel;
			// MathLang.g:21:7: ( '()' )
			DebugEnterAlt(1);
			// MathLang.g:21:9: '()'
			{
			DebugLocation(21, 9);
			Match("()"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__35", 13);
			LeaveRule("T__35", 13);
			Leave_T__35();
		}
	}
	// $ANTLR end "T__35"

	partial void Enter_T__36();
	partial void Leave_T__36();

	// $ANTLR start "T__36"
	[GrammarRule("T__36")]
	private void mT__36()
	{
		Enter_T__36();
		EnterRule("T__36", 14);
		TraceIn("T__36", 14);
		try
		{
			int _type = T__36;
			int _channel = DefaultTokenChannel;
			// MathLang.g:22:7: ( '\"' )
			DebugEnterAlt(1);
			// MathLang.g:22:9: '\"'
			{
			DebugLocation(22, 9);
			Match('\"'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("T__36", 14);
			LeaveRule("T__36", 14);
			Leave_T__36();
		}
	}
	// $ANTLR end "T__36"

	partial void Enter_WS();
	partial void Leave_WS();

	// $ANTLR start "WS"
	[GrammarRule("WS")]
	private void mWS()
	{
		Enter_WS();
		EnterRule("WS", 15);
		TraceIn("WS", 15);
		try
		{
			int _type = WS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:32:3: ( ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+ )
			DebugEnterAlt(1);
			// MathLang.g:33:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			{
			DebugLocation(33, 3);
			// MathLang.g:33:3: ( ' ' | '\\t' | '\\f' | '\\r' | '\\n' )+
			int cnt1=0;
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, decisionCanBacktrack[1]);
				int LA1_0 = input.LA(1);

				if (((LA1_0>='\t' && LA1_0<='\n')||(LA1_0>='\f' && LA1_0<='\r')||LA1_0==' '))
				{
					alt1=1;
				}


				} finally { DebugExitDecision(1); }
				switch (alt1)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:
					{
					DebugLocation(33, 3);
					if ((input.LA(1)>='\t' && input.LA(1)<='\n')||(input.LA(1)>='\f' && input.LA(1)<='\r')||input.LA(1)==' ')
					{
						input.Consume();

					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						Recover(mse);
						throw mse;}


					}
					break;

				default:
					if (cnt1 >= 1)
						goto loop1;

					EarlyExitException eee1 = new EarlyExitException( 1, input );
					DebugRecognitionException(eee1);
					throw eee1;
				}
				cnt1++;
			}
			loop1:
				;

			} finally { DebugExitSubRule(1); }

			DebugLocation(33, 41);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WS", 15);
			LeaveRule("WS", 15);
			Leave_WS();
		}
	}
	// $ANTLR end "WS"

	partial void Enter_SL_COMMENT();
	partial void Leave_SL_COMMENT();

	// $ANTLR start "SL_COMMENT"
	[GrammarRule("SL_COMMENT")]
	private void mSL_COMMENT()
	{
		Enter_SL_COMMENT();
		EnterRule("SL_COMMENT", 16);
		TraceIn("SL_COMMENT", 16);
		try
		{
			int _type = SL_COMMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:38:11: ( '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n' )
			DebugEnterAlt(1);
			// MathLang.g:39:3: '//' ( options {greedy=false; } : . )* ( '\\r' )? '\\n'
			{
			DebugLocation(39, 3);
			Match("//"); 

			DebugLocation(39, 8);
			// MathLang.g:39:8: ( options {greedy=false; } : . )*
			try { DebugEnterSubRule(2);
			while (true)
			{
				int alt2=2;
				try { DebugEnterDecision(2, decisionCanBacktrack[2]);
				int LA2_0 = input.LA(1);

				if ((LA2_0=='\r'))
				{
					alt2=2;
				}
				else if ((LA2_0=='\n'))
				{
					alt2=2;
				}
				else if (((LA2_0>='\u0000' && LA2_0<='\t')||(LA2_0>='\u000B' && LA2_0<='\f')||(LA2_0>='\u000E' && LA2_0<='\uFFFF')))
				{
					alt2=1;
				}


				} finally { DebugExitDecision(2); }
				switch ( alt2 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:39:36: .
					{
					DebugLocation(39, 36);
					MatchAny(); 

					}
					break;

				default:
					goto loop2;
				}
			}

			loop2:
				;

			} finally { DebugExitSubRule(2); }

			DebugLocation(39, 40);
			// MathLang.g:39:40: ( '\\r' )?
			int alt3=2;
			try { DebugEnterSubRule(3);
			try { DebugEnterDecision(3, decisionCanBacktrack[3]);
			int LA3_0 = input.LA(1);

			if ((LA3_0=='\r'))
			{
				alt3=1;
			}
			} finally { DebugExitDecision(3); }
			switch (alt3)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:39:40: '\\r'
				{
				DebugLocation(39, 40);
				Match('\r'); 

				}
				break;

			}
			} finally { DebugExitSubRule(3); }

			DebugLocation(39, 46);
			Match('\n'); 
			DebugLocation(39, 51);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SL_COMMENT", 16);
			LeaveRule("SL_COMMENT", 16);
			Leave_SL_COMMENT();
		}
	}
	// $ANTLR end "SL_COMMENT"

	partial void Enter_ML_COMMENT();
	partial void Leave_ML_COMMENT();

	// $ANTLR start "ML_COMMENT"
	[GrammarRule("ML_COMMENT")]
	private void mML_COMMENT()
	{
		Enter_ML_COMMENT();
		EnterRule("ML_COMMENT", 17);
		TraceIn("ML_COMMENT", 17);
		try
		{
			int _type = ML_COMMENT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:43:11: ( '/*' ( options {greedy=false; } : . )* '*/' )
			DebugEnterAlt(1);
			// MathLang.g:44:3: '/*' ( options {greedy=false; } : . )* '*/'
			{
			DebugLocation(44, 3);
			Match("/*"); 

			DebugLocation(44, 8);
			// MathLang.g:44:8: ( options {greedy=false; } : . )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, decisionCanBacktrack[4]);
				int LA4_0 = input.LA(1);

				if ((LA4_0=='*'))
				{
					int LA4_1 = input.LA(2);

					if ((LA4_1=='/'))
					{
						alt4=2;
					}
					else if (((LA4_1>='\u0000' && LA4_1<='.')||(LA4_1>='0' && LA4_1<='\uFFFF')))
					{
						alt4=1;
					}


				}
				else if (((LA4_0>='\u0000' && LA4_0<=')')||(LA4_0>='+' && LA4_0<='\uFFFF')))
				{
					alt4=1;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:44:36: .
					{
					DebugLocation(44, 36);
					MatchAny(); 

					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }

			DebugLocation(44, 40);
			Match("*/"); 

			DebugLocation(44, 45);

			    _channel=Hidden;
			  

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ML_COMMENT", 17);
			LeaveRule("ML_COMMENT", 17);
			Leave_ML_COMMENT();
		}
	}
	// $ANTLR end "ML_COMMENT"

	partial void Enter_ATOM();
	partial void Leave_ATOM();

	// $ANTLR start "ATOM"
	[GrammarRule("ATOM")]
	private void mATOM()
	{
		Enter_ATOM();
		EnterRule("ATOM", 18);
		TraceIn("ATOM", 18);
		try
		{
			int _type = ATOM;
			int _channel = DefaultTokenChannel;
			// MathLang.g:49:5: ( ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )? )
			DebugEnterAlt(1);
			// MathLang.g:49:12: ( '0' .. '9' )+ ( '.' ( '0' .. '9' )+ )?
			{
			DebugLocation(49, 12);
			// MathLang.g:49:12: ( '0' .. '9' )+
			int cnt5=0;
			try { DebugEnterSubRule(5);
			while (true)
			{
				int alt5=2;
				try { DebugEnterDecision(5, decisionCanBacktrack[5]);
				int LA5_0 = input.LA(1);

				if (((LA5_0>='0' && LA5_0<='9')))
				{
					alt5=1;
				}


				} finally { DebugExitDecision(5); }
				switch (alt5)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:49:13: '0' .. '9'
					{
					DebugLocation(49, 13);
					MatchRange('0','9'); 

					}
					break;

				default:
					if (cnt5 >= 1)
						goto loop5;

					EarlyExitException eee5 = new EarlyExitException( 5, input );
					DebugRecognitionException(eee5);
					throw eee5;
				}
				cnt5++;
			}
			loop5:
				;

			} finally { DebugExitSubRule(5); }

			DebugLocation(49, 24);
			// MathLang.g:49:24: ( '.' ( '0' .. '9' )+ )?
			int alt7=2;
			try { DebugEnterSubRule(7);
			try { DebugEnterDecision(7, decisionCanBacktrack[7]);
			int LA7_0 = input.LA(1);

			if ((LA7_0=='.'))
			{
				alt7=1;
			}
			} finally { DebugExitDecision(7); }
			switch (alt7)
			{
			case 1:
				DebugEnterAlt(1);
				// MathLang.g:49:25: '.' ( '0' .. '9' )+
				{
				DebugLocation(49, 25);
				Match('.'); 
				DebugLocation(49, 29);
				// MathLang.g:49:29: ( '0' .. '9' )+
				int cnt6=0;
				try { DebugEnterSubRule(6);
				while (true)
				{
					int alt6=2;
					try { DebugEnterDecision(6, decisionCanBacktrack[6]);
					int LA6_0 = input.LA(1);

					if (((LA6_0>='0' && LA6_0<='9')))
					{
						alt6=1;
					}


					} finally { DebugExitDecision(6); }
					switch (alt6)
					{
					case 1:
						DebugEnterAlt(1);
						// MathLang.g:49:30: '0' .. '9'
						{
						DebugLocation(49, 30);
						MatchRange('0','9'); 

						}
						break;

					default:
						if (cnt6 >= 1)
							goto loop6;

						EarlyExitException eee6 = new EarlyExitException( 6, input );
						DebugRecognitionException(eee6);
						throw eee6;
					}
					cnt6++;
				}
				loop6:
					;

				} finally { DebugExitSubRule(6); }


				}
				break;

			}
			} finally { DebugExitSubRule(7); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ATOM", 18);
			LeaveRule("ATOM", 18);
			Leave_ATOM();
		}
	}
	// $ANTLR end "ATOM"

	partial void Enter_WORD();
	partial void Leave_WORD();

	// $ANTLR start "WORD"
	[GrammarRule("WORD")]
	private void mWORD()
	{
		Enter_WORD();
		EnterRule("WORD", 19);
		TraceIn("WORD", 19);
		try
		{
			int _type = WORD;
			int _channel = DefaultTokenChannel;
			// MathLang.g:50:5: ( ( ( 'a' .. 'z' ) | ( 'A' .. 'Z' ) | ( '0' .. '9' ) )+ )
			DebugEnterAlt(1);
			// MathLang.g:50:12: ( ( 'a' .. 'z' ) | ( 'A' .. 'Z' ) | ( '0' .. '9' ) )+
			{
			DebugLocation(50, 12);
			// MathLang.g:50:12: ( ( 'a' .. 'z' ) | ( 'A' .. 'Z' ) | ( '0' .. '9' ) )+
			int cnt8=0;
			try { DebugEnterSubRule(8);
			while (true)
			{
				int alt8=4;
				try { DebugEnterDecision(8, decisionCanBacktrack[8]);
				switch (input.LA(1))
				{
				case 'a':
				case 'b':
				case 'c':
				case 'd':
				case 'e':
				case 'f':
				case 'g':
				case 'h':
				case 'i':
				case 'j':
				case 'k':
				case 'l':
				case 'm':
				case 'n':
				case 'o':
				case 'p':
				case 'q':
				case 'r':
				case 's':
				case 't':
				case 'u':
				case 'v':
				case 'w':
				case 'x':
				case 'y':
				case 'z':
					{
					alt8=1;
					}
					break;
				case 'A':
				case 'B':
				case 'C':
				case 'D':
				case 'E':
				case 'F':
				case 'G':
				case 'H':
				case 'I':
				case 'J':
				case 'K':
				case 'L':
				case 'M':
				case 'N':
				case 'O':
				case 'P':
				case 'Q':
				case 'R':
				case 'S':
				case 'T':
				case 'U':
				case 'V':
				case 'W':
				case 'X':
				case 'Y':
				case 'Z':
					{
					alt8=2;
					}
					break;
				case '0':
				case '1':
				case '2':
				case '3':
				case '4':
				case '5':
				case '6':
				case '7':
				case '8':
				case '9':
					{
					alt8=3;
					}
					break;

				}

				} finally { DebugExitDecision(8); }
				switch (alt8)
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:50:13: ( 'a' .. 'z' )
					{
					DebugLocation(50, 13);
					// MathLang.g:50:13: ( 'a' .. 'z' )
					DebugEnterAlt(1);
					// MathLang.g:50:14: 'a' .. 'z'
					{
					DebugLocation(50, 14);
					MatchRange('a','z'); 

					}


					}
					break;
				case 2:
					DebugEnterAlt(2);
					// MathLang.g:50:26: ( 'A' .. 'Z' )
					{
					DebugLocation(50, 26);
					// MathLang.g:50:26: ( 'A' .. 'Z' )
					DebugEnterAlt(1);
					// MathLang.g:50:27: 'A' .. 'Z'
					{
					DebugLocation(50, 27);
					MatchRange('A','Z'); 

					}


					}
					break;
				case 3:
					DebugEnterAlt(3);
					// MathLang.g:50:39: ( '0' .. '9' )
					{
					DebugLocation(50, 39);
					// MathLang.g:50:39: ( '0' .. '9' )
					DebugEnterAlt(1);
					// MathLang.g:50:40: '0' .. '9'
					{
					DebugLocation(50, 40);
					MatchRange('0','9'); 

					}


					}
					break;

				default:
					if (cnt8 >= 1)
						goto loop8;

					EarlyExitException eee8 = new EarlyExitException( 8, input );
					DebugRecognitionException(eee8);
					throw eee8;
				}
				cnt8++;
			}
			loop8:
				;

			} finally { DebugExitSubRule(8); }


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("WORD", 19);
			LeaveRule("WORD", 19);
			Leave_WORD();
		}
	}
	// $ANTLR end "WORD"

	partial void Enter_VARIABLE();
	partial void Leave_VARIABLE();

	// $ANTLR start "VARIABLE"
	[GrammarRule("VARIABLE")]
	private void mVARIABLE()
	{
		Enter_VARIABLE();
		EnterRule("VARIABLE", 20);
		TraceIn("VARIABLE", 20);
		try
		{
			int _type = VARIABLE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:51:9: ( ( '_' )* WORD )
			DebugEnterAlt(1);
			// MathLang.g:51:11: ( '_' )* WORD
			{
			DebugLocation(51, 11);
			// MathLang.g:51:11: ( '_' )*
			try { DebugEnterSubRule(9);
			while (true)
			{
				int alt9=2;
				try { DebugEnterDecision(9, decisionCanBacktrack[9]);
				int LA9_0 = input.LA(1);

				if ((LA9_0=='_'))
				{
					alt9=1;
				}


				} finally { DebugExitDecision(9); }
				switch ( alt9 )
				{
				case 1:
					DebugEnterAlt(1);
					// MathLang.g:51:12: '_'
					{
					DebugLocation(51, 12);
					Match('_'); 

					}
					break;

				default:
					goto loop9;
				}
			}

			loop9:
				;

			} finally { DebugExitSubRule(9); }

			DebugLocation(51, 18);
			mWORD(); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("VARIABLE", 20);
			LeaveRule("VARIABLE", 20);
			Leave_VARIABLE();
		}
	}
	// $ANTLR end "VARIABLE"

	partial void Enter_ADD();
	partial void Leave_ADD();

	// $ANTLR start "ADD"
	[GrammarRule("ADD")]
	private void mADD()
	{
		Enter_ADD();
		EnterRule("ADD", 21);
		TraceIn("ADD", 21);
		try
		{
			int _type = ADD;
			int _channel = DefaultTokenChannel;
			// MathLang.g:53:4: ( '+' )
			DebugEnterAlt(1);
			// MathLang.g:53:9: '+'
			{
			DebugLocation(53, 9);
			Match('+'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("ADD", 21);
			LeaveRule("ADD", 21);
			Leave_ADD();
		}
	}
	// $ANTLR end "ADD"

	partial void Enter_SUB();
	partial void Leave_SUB();

	// $ANTLR start "SUB"
	[GrammarRule("SUB")]
	private void mSUB()
	{
		Enter_SUB();
		EnterRule("SUB", 22);
		TraceIn("SUB", 22);
		try
		{
			int _type = SUB;
			int _channel = DefaultTokenChannel;
			// MathLang.g:54:4: ( '-' )
			DebugEnterAlt(1);
			// MathLang.g:54:9: '-'
			{
			DebugLocation(54, 9);
			Match('-'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("SUB", 22);
			LeaveRule("SUB", 22);
			Leave_SUB();
		}
	}
	// $ANTLR end "SUB"

	partial void Enter_MUL();
	partial void Leave_MUL();

	// $ANTLR start "MUL"
	[GrammarRule("MUL")]
	private void mMUL()
	{
		Enter_MUL();
		EnterRule("MUL", 23);
		TraceIn("MUL", 23);
		try
		{
			int _type = MUL;
			int _channel = DefaultTokenChannel;
			// MathLang.g:55:4: ( '*' )
			DebugEnterAlt(1);
			// MathLang.g:55:9: '*'
			{
			DebugLocation(55, 9);
			Match('*'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("MUL", 23);
			LeaveRule("MUL", 23);
			Leave_MUL();
		}
	}
	// $ANTLR end "MUL"

	partial void Enter_DIV();
	partial void Leave_DIV();

	// $ANTLR start "DIV"
	[GrammarRule("DIV")]
	private void mDIV()
	{
		Enter_DIV();
		EnterRule("DIV", 24);
		TraceIn("DIV", 24);
		try
		{
			int _type = DIV;
			int _channel = DefaultTokenChannel;
			// MathLang.g:56:4: ( '/' )
			DebugEnterAlt(1);
			// MathLang.g:56:9: '/'
			{
			DebugLocation(56, 9);
			Match('/'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DIV", 24);
			LeaveRule("DIV", 24);
			Leave_DIV();
		}
	}
	// $ANTLR end "DIV"

	partial void Enter_GE();
	partial void Leave_GE();

	// $ANTLR start "GE"
	[GrammarRule("GE")]
	private void mGE()
	{
		Enter_GE();
		EnterRule("GE", 25);
		TraceIn("GE", 25);
		try
		{
			int _type = GE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:58:3: ( '>=' )
			DebugEnterAlt(1);
			// MathLang.g:58:11: '>='
			{
			DebugLocation(58, 11);
			Match(">="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GE", 25);
			LeaveRule("GE", 25);
			Leave_GE();
		}
	}
	// $ANTLR end "GE"

	partial void Enter_LE();
	partial void Leave_LE();

	// $ANTLR start "LE"
	[GrammarRule("LE")]
	private void mLE()
	{
		Enter_LE();
		EnterRule("LE", 26);
		TraceIn("LE", 26);
		try
		{
			int _type = LE;
			int _channel = DefaultTokenChannel;
			// MathLang.g:59:3: ( '<=' )
			DebugEnterAlt(1);
			// MathLang.g:59:11: '<='
			{
			DebugLocation(59, 11);
			Match("<="); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LE", 26);
			LeaveRule("LE", 26);
			Leave_LE();
		}
	}
	// $ANTLR end "LE"

	partial void Enter_NEQUALS();
	partial void Leave_NEQUALS();

	// $ANTLR start "NEQUALS"
	[GrammarRule("NEQUALS")]
	private void mNEQUALS()
	{
		Enter_NEQUALS();
		EnterRule("NEQUALS", 27);
		TraceIn("NEQUALS", 27);
		try
		{
			int _type = NEQUALS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:60:8: ( '<>' )
			DebugEnterAlt(1);
			// MathLang.g:60:11: '<>'
			{
			DebugLocation(60, 11);
			Match("<>"); 


			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("NEQUALS", 27);
			LeaveRule("NEQUALS", 27);
			Leave_NEQUALS();
		}
	}
	// $ANTLR end "NEQUALS"

	partial void Enter_GT();
	partial void Leave_GT();

	// $ANTLR start "GT"
	[GrammarRule("GT")]
	private void mGT()
	{
		Enter_GT();
		EnterRule("GT", 28);
		TraceIn("GT", 28);
		try
		{
			int _type = GT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:61:3: ( '>' )
			DebugEnterAlt(1);
			// MathLang.g:61:11: '>'
			{
			DebugLocation(61, 11);
			Match('>'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("GT", 28);
			LeaveRule("GT", 28);
			Leave_GT();
		}
	}
	// $ANTLR end "GT"

	partial void Enter_LT();
	partial void Leave_LT();

	// $ANTLR start "LT"
	[GrammarRule("LT")]
	private void mLT()
	{
		Enter_LT();
		EnterRule("LT", 29);
		TraceIn("LT", 29);
		try
		{
			int _type = LT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:62:3: ( '<' )
			DebugEnterAlt(1);
			// MathLang.g:62:11: '<'
			{
			DebugLocation(62, 11);
			Match('<'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("LT", 29);
			LeaveRule("LT", 29);
			Leave_LT();
		}
	}
	// $ANTLR end "LT"

	partial void Enter_EQUALS();
	partial void Leave_EQUALS();

	// $ANTLR start "EQUALS"
	[GrammarRule("EQUALS")]
	private void mEQUALS()
	{
		Enter_EQUALS();
		EnterRule("EQUALS", 30);
		TraceIn("EQUALS", 30);
		try
		{
			int _type = EQUALS;
			int _channel = DefaultTokenChannel;
			// MathLang.g:63:7: ( '=' )
			DebugEnterAlt(1);
			// MathLang.g:63:11: '='
			{
			DebugLocation(63, 11);
			Match('='); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("EQUALS", 30);
			LeaveRule("EQUALS", 30);
			Leave_EQUALS();
		}
	}
	// $ANTLR end "EQUALS"

	partial void Enter_DOT();
	partial void Leave_DOT();

	// $ANTLR start "DOT"
	[GrammarRule("DOT")]
	private void mDOT()
	{
		Enter_DOT();
		EnterRule("DOT", 31);
		TraceIn("DOT", 31);
		try
		{
			int _type = DOT;
			int _channel = DefaultTokenChannel;
			// MathLang.g:67:4: ( '.' )
			DebugEnterAlt(1);
			// MathLang.g:67:6: '.'
			{
			DebugLocation(67, 6);
			Match('.'); 

			}

			state.type = _type;
			state.channel = _channel;
		}
		finally
		{
			TraceOut("DOT", 31);
			LeaveRule("DOT", 31);
			Leave_DOT();
		}
	}
	// $ANTLR end "DOT"

	public override void mTokens()
	{
		// MathLang.g:1:8: ( NULL | NIL | QUOTE | CAR | CDR | CONS | EQUAL | DEFUN | ASSIGN | IF | T__33 | T__34 | T__35 | T__36 | WS | SL_COMMENT | ML_COMMENT | ATOM | WORD | VARIABLE | ADD | SUB | MUL | DIV | GE | LE | NEQUALS | GT | LT | EQUALS | DOT )
		int alt10=31;
		try { DebugEnterDecision(10, decisionCanBacktrack[10]);
		try
		{
			alt10 = dfa10.Predict(input);
		}
		catch (NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
			throw;
		}
		} finally { DebugExitDecision(10); }
		switch (alt10)
		{
		case 1:
			DebugEnterAlt(1);
			// MathLang.g:1:10: NULL
			{
			DebugLocation(1, 10);
			mNULL(); 

			}
			break;
		case 2:
			DebugEnterAlt(2);
			// MathLang.g:1:15: NIL
			{
			DebugLocation(1, 15);
			mNIL(); 

			}
			break;
		case 3:
			DebugEnterAlt(3);
			// MathLang.g:1:19: QUOTE
			{
			DebugLocation(1, 19);
			mQUOTE(); 

			}
			break;
		case 4:
			DebugEnterAlt(4);
			// MathLang.g:1:25: CAR
			{
			DebugLocation(1, 25);
			mCAR(); 

			}
			break;
		case 5:
			DebugEnterAlt(5);
			// MathLang.g:1:29: CDR
			{
			DebugLocation(1, 29);
			mCDR(); 

			}
			break;
		case 6:
			DebugEnterAlt(6);
			// MathLang.g:1:33: CONS
			{
			DebugLocation(1, 33);
			mCONS(); 

			}
			break;
		case 7:
			DebugEnterAlt(7);
			// MathLang.g:1:38: EQUAL
			{
			DebugLocation(1, 38);
			mEQUAL(); 

			}
			break;
		case 8:
			DebugEnterAlt(8);
			// MathLang.g:1:44: DEFUN
			{
			DebugLocation(1, 44);
			mDEFUN(); 

			}
			break;
		case 9:
			DebugEnterAlt(9);
			// MathLang.g:1:50: ASSIGN
			{
			DebugLocation(1, 50);
			mASSIGN(); 

			}
			break;
		case 10:
			DebugEnterAlt(10);
			// MathLang.g:1:57: IF
			{
			DebugLocation(1, 57);
			mIF(); 

			}
			break;
		case 11:
			DebugEnterAlt(11);
			// MathLang.g:1:60: T__33
			{
			DebugLocation(1, 60);
			mT__33(); 

			}
			break;
		case 12:
			DebugEnterAlt(12);
			// MathLang.g:1:66: T__34
			{
			DebugLocation(1, 66);
			mT__34(); 

			}
			break;
		case 13:
			DebugEnterAlt(13);
			// MathLang.g:1:72: T__35
			{
			DebugLocation(1, 72);
			mT__35(); 

			}
			break;
		case 14:
			DebugEnterAlt(14);
			// MathLang.g:1:78: T__36
			{
			DebugLocation(1, 78);
			mT__36(); 

			}
			break;
		case 15:
			DebugEnterAlt(15);
			// MathLang.g:1:84: WS
			{
			DebugLocation(1, 84);
			mWS(); 

			}
			break;
		case 16:
			DebugEnterAlt(16);
			// MathLang.g:1:87: SL_COMMENT
			{
			DebugLocation(1, 87);
			mSL_COMMENT(); 

			}
			break;
		case 17:
			DebugEnterAlt(17);
			// MathLang.g:1:98: ML_COMMENT
			{
			DebugLocation(1, 98);
			mML_COMMENT(); 

			}
			break;
		case 18:
			DebugEnterAlt(18);
			// MathLang.g:1:109: ATOM
			{
			DebugLocation(1, 109);
			mATOM(); 

			}
			break;
		case 19:
			DebugEnterAlt(19);
			// MathLang.g:1:114: WORD
			{
			DebugLocation(1, 114);
			mWORD(); 

			}
			break;
		case 20:
			DebugEnterAlt(20);
			// MathLang.g:1:119: VARIABLE
			{
			DebugLocation(1, 119);
			mVARIABLE(); 

			}
			break;
		case 21:
			DebugEnterAlt(21);
			// MathLang.g:1:128: ADD
			{
			DebugLocation(1, 128);
			mADD(); 

			}
			break;
		case 22:
			DebugEnterAlt(22);
			// MathLang.g:1:132: SUB
			{
			DebugLocation(1, 132);
			mSUB(); 

			}
			break;
		case 23:
			DebugEnterAlt(23);
			// MathLang.g:1:136: MUL
			{
			DebugLocation(1, 136);
			mMUL(); 

			}
			break;
		case 24:
			DebugEnterAlt(24);
			// MathLang.g:1:140: DIV
			{
			DebugLocation(1, 140);
			mDIV(); 

			}
			break;
		case 25:
			DebugEnterAlt(25);
			// MathLang.g:1:144: GE
			{
			DebugLocation(1, 144);
			mGE(); 

			}
			break;
		case 26:
			DebugEnterAlt(26);
			// MathLang.g:1:147: LE
			{
			DebugLocation(1, 147);
			mLE(); 

			}
			break;
		case 27:
			DebugEnterAlt(27);
			// MathLang.g:1:150: NEQUALS
			{
			DebugLocation(1, 150);
			mNEQUALS(); 

			}
			break;
		case 28:
			DebugEnterAlt(28);
			// MathLang.g:1:158: GT
			{
			DebugLocation(1, 158);
			mGT(); 

			}
			break;
		case 29:
			DebugEnterAlt(29);
			// MathLang.g:1:161: LT
			{
			DebugLocation(1, 161);
			mLT(); 

			}
			break;
		case 30:
			DebugEnterAlt(30);
			// MathLang.g:1:164: EQUALS
			{
			DebugLocation(1, 164);
			mEQUALS(); 

			}
			break;
		case 31:
			DebugEnterAlt(31);
			// MathLang.g:1:171: DOT
			{
			DebugLocation(1, 171);
			mDOT(); 

			}
			break;

		}

	}


	#region DFA
	DFA10 dfa10;

	protected override void InitDFAs()
	{
		base.InitDFAs();
		dfa10 = new DFA10(this);
	}

	private class DFA10 : DFA
	{
		private const string DFA10_eotS =
			"\x1\xFFFF\x1\x1A\x1\xFFFF\x3\x1A\x1\xFFFF\x1\x1A\x1\x23\x3\xFFFF\x1"+
			"\x26\x1\x27\x2\x1A\x4\xFFFF\x1\x29\x1\x2C\x2\xFFFF\x2\x1A\x1\xFFFF\x6"+
			"\x1A\x1\x34\xB\xFFFF\x1\x1A\x1\x36\x1\x37\x1\x38\x3\x1A\x1\xFFFF\x1\x3C"+
			"\x3\xFFFF\x1\x3D\x2\x1A\x2\xFFFF\x1\x40\x1\x41\x2\xFFFF";
		private const string DFA10_eofS =
			"\x42\xFFFF";
		private const string DFA10_minS =
			"\x1\x9\x1\x30\x1\xFFFF\x3\x30\x1\xFFFF\x1\x30\x1\x29\x3\xFFFF\x1\x2A"+
			"\x3\x30\x4\xFFFF\x2\x3D\x2\xFFFF\x2\x30\x1\xFFFF\x7\x30\xB\xFFFF\x7\x30"+
			"\x1\xFFFF\x1\x30\x3\xFFFF\x3\x30\x2\xFFFF\x2\x30\x2\xFFFF";
		private const string DFA10_maxS =
			"\x2\x7A\x1\xFFFF\x3\x7A\x1\xFFFF\x1\x7A\x1\x29\x3\xFFFF\x1\x2F\x3\x7A"+
			"\x4\xFFFF\x1\x3D\x1\x3E\x2\xFFFF\x2\x7A\x1\xFFFF\x7\x7A\xB\xFFFF\x7\x7A"+
			"\x1\xFFFF\x1\x7A\x3\xFFFF\x3\x7A\x2\xFFFF\x2\x7A\x2\xFFFF";
		private const string DFA10_acceptS =
			"\x2\xFFFF\x1\x3\x3\xFFFF\x1\x9\x2\xFFFF\x1\xC\x1\xE\x1\xF\x4\xFFFF\x1"+
			"\x14\x1\x15\x1\x16\x1\x17\x2\xFFFF\x1\x1E\x1\x1F\x2\xFFFF\x1\x13\x7\xFFFF"+
			"\x1\xD\x1\xB\x1\x10\x1\x11\x1\x18\x1\x12\x1\x19\x1\x1C\x1\x1A\x1\x1B"+
			"\x1\x1D\x7\xFFFF\x1\xA\x1\xFFFF\x1\x2\x1\x4\x1\x5\x3\xFFFF\x1\x1\x1\x6"+
			"\x2\xFFFF\x1\x7\x1\x8";
		private const string DFA10_specialS =
			"\x42\xFFFF}>";
		private static readonly string[] DFA10_transitionS =
			{
				"\x2\xB\x1\xFFFF\x2\xB\x12\xFFFF\x1\xB\x1\xFFFF\x1\xA\x4\xFFFF\x1\x2"+
				"\x1\x8\x1\x9\x1\x13\x1\x11\x1\xFFFF\x1\x12\x1\x17\x1\xC\xA\xD\x1\x6"+
				"\x1\xFFFF\x1\x15\x1\x16\x1\x14\x2\xFFFF\x1A\xF\x4\xFFFF\x1\x10\x1\xFFFF"+
				"\x2\xE\x1\x3\x1\x5\x1\x4\x3\xE\x1\x7\x4\xE\x1\x1\xC\xE",
				"\xA\x1B\x7\xFFFF\x1A\xF\x6\xFFFF\x8\xE\x1\x19\xB\xE\x1\x18\x5\xE",
				"",
				"\xA\x1B\x7\xFFFF\x1A\xF\x6\xFFFF\x1\x1C\x2\xE\x1\x1D\xA\xE\x1\x1E"+
				"\xB\xE",
				"\xA\x1B\x7\xFFFF\x1A\xF\x6\xFFFF\x10\xE\x1\x1F\x9\xE",
				"\xA\x1B\x7\xFFFF\x1A\xF\x6\xFFFF\x4\xE\x1\x20\x15\xE",
				"",
				"\xA\x1B\x7\xFFFF\x1A\xF\x6\xFFFF\x5\xE\x1\x21\x14\xE",
				"\x1\x22",
				"",
				"",
				"",
				"\x1\x25\x4\xFFFF\x1\x24",
				"\xA\xD\x7\xFFFF\x1A\xF\x6\xFFFF\x1A\xE",
				"\xA\x1B\x7\xFFFF\x1A\xF\x6\xFFFF\x1A\xE",
				"\xA\x1B\x7\xFFFF\x1A\xF\x6\xFFFF\x1A\xE",
				"",
				"",
				"",
				"",
				"\x1\x28",
				"\x1\x2A\x1\x2B",
				"",
				"",
				"\xA\x1B\x7\xFFFF\x1A\xF\x6\xFFFF\xB\xE\x1\x2D\xE\xE",
				"\xA\x1B\x7\xFFFF\x1A\xF\x6\xFFFF\xB\xE\x1\x2E\xE\xE",
				"",
				"\xA\x1B\x7\xFFFF\x1A\xF\x6\xFFFF\x1A\xE",
				"\xA\x1B\x7\xFFFF\x1A\xF\x6\xFFFF\x11\xE\x1\x2F\x8\xE",
				"\xA\x1B\x7\xFFFF\x1A\xF\x6\xFFFF\x11\xE\x1\x30\x8\xE",
				"\xA\x1B\x7\xFFFF\x1A\xF\x6\xFFFF\xD\xE\x1\x31\xC\xE",
				"\xA\x1B\x7\xFFFF\x1A\xF\x6\xFFFF\x14\xE\x1\x32\x5\xE",
				"\xA\x1B\x7\xFFFF\x1A\xF\x6\xFFFF\x5\xE\x1\x33\x14\xE",
				"\xA\x1B\x7\xFFFF\x1A\xF\x6\xFFFF\x1A\xE",
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
				"\xA\x1B\x7\xFFFF\x1A\xF\x6\xFFFF\xB\xE\x1\x35\xE\xE",
				"\xA\x1B\x7\xFFFF\x1A\xF\x6\xFFFF\x1A\xE",
				"\xA\x1B\x7\xFFFF\x1A\xF\x6\xFFFF\x1A\xE",
				"\xA\x1B\x7\xFFFF\x1A\xF\x6\xFFFF\x1A\xE",
				"\xA\x1B\x7\xFFFF\x1A\xF\x6\xFFFF\x12\xE\x1\x39\x7\xE",
				"\xA\x1B\x7\xFFFF\x1A\xF\x6\xFFFF\x1\x3A\x19\xE",
				"\xA\x1B\x7\xFFFF\x1A\xF\x6\xFFFF\x14\xE\x1\x3B\x5\xE",
				"",
				"\xA\x1B\x7\xFFFF\x1A\xF\x6\xFFFF\x1A\xE",
				"",
				"",
				"",
				"\xA\x1B\x7\xFFFF\x1A\xF\x6\xFFFF\x1A\xE",
				"\xA\x1B\x7\xFFFF\x1A\xF\x6\xFFFF\xB\xE\x1\x3E\xE\xE",
				"\xA\x1B\x7\xFFFF\x1A\xF\x6\xFFFF\xD\xE\x1\x3F\xC\xE",
				"",
				"",
				"\xA\x1B\x7\xFFFF\x1A\xF\x6\xFFFF\x1A\xE",
				"\xA\x1B\x7\xFFFF\x1A\xF\x6\xFFFF\x1A\xE",
				"",
				""
			};

		private static readonly short[] DFA10_eot = DFA.UnpackEncodedString(DFA10_eotS);
		private static readonly short[] DFA10_eof = DFA.UnpackEncodedString(DFA10_eofS);
		private static readonly char[] DFA10_min = DFA.UnpackEncodedStringToUnsignedChars(DFA10_minS);
		private static readonly char[] DFA10_max = DFA.UnpackEncodedStringToUnsignedChars(DFA10_maxS);
		private static readonly short[] DFA10_accept = DFA.UnpackEncodedString(DFA10_acceptS);
		private static readonly short[] DFA10_special = DFA.UnpackEncodedString(DFA10_specialS);
		private static readonly short[][] DFA10_transition;

		static DFA10()
		{
			int numStates = DFA10_transitionS.Length;
			DFA10_transition = new short[numStates][];
			for ( int i=0; i < numStates; i++ )
			{
				DFA10_transition[i] = DFA.UnpackEncodedString(DFA10_transitionS[i]);
			}
		}

		public DFA10( BaseRecognizer recognizer )
		{
			this.recognizer = recognizer;
			this.decisionNumber = 10;
			this.eot = DFA10_eot;
			this.eof = DFA10_eof;
			this.min = DFA10_min;
			this.max = DFA10_max;
			this.accept = DFA10_accept;
			this.special = DFA10_special;
			this.transition = DFA10_transition;
		}

		public override string Description { get { return "1:1: Tokens : ( NULL | NIL | QUOTE | CAR | CDR | CONS | EQUAL | DEFUN | ASSIGN | IF | T__33 | T__34 | T__35 | T__36 | WS | SL_COMMENT | ML_COMMENT | ATOM | WORD | VARIABLE | ADD | SUB | MUL | DIV | GE | LE | NEQUALS | GT | LT | EQUALS | DOT );"; } }

		public override void Error(NoViableAltException nvae)
		{
			DebugRecognitionException(nvae);
		}
	}

 
	#endregion

}

} // namespace  MathLang 
