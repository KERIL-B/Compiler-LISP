grammar MathLang;

options {
  language=CSharp3;
  output=AST;

  backtrack=true;
  memoize=true;
}


tokens { 
NULL   =  'null'   ;
NIL    =  'nil'    ;
QUOTE  =  '\''     ;
CAR    =  'car'    ;
CDR    =  'cdr'    ;
CONS   =  'cons'   ;
EQUAL  =  'equal'  ;
DEFUN  =  'defun'  ;
ASSIGN =  '::='    ;
IF     =  'if'     ;
BLOCK              ; 
PROGRAM            ;
}


@lexer::namespace { MathLang }
@parser::namespace { MathLang }


WS:
  ( ' ' | '\t' |  '\f' | '\r' | '\n' )+ {
    $channel=Hidden;
  }
;

SL_COMMENT:
  '//' (options { greedy=false; }: .)* '\r'? '\n' {
    $channel=Hidden;
  }
;
ML_COMMENT:
  '/*' (options { greedy=false; }: .)* '*/' {
    $channel=Hidden;
  }
;
 
ATOM:      ('0'..'9')+ ('.' ('0'..'9')+)?                           ;
WORD:      (('a'..'z') | ('A'..'Z') | ('0'..'9'))+                  ;
VARIABLE: ('_')* WORD ;

ADD:    '+'     ;
SUB:    '-'     ;
MUL:    '*'     ;
DIV:    '/'     ;

GE:       '>='  ;
LE:       '<='  ;
NEQUALS:  '<>'  ;
GT:       '>'   ;
LT:       '<'   ;
EQUALS:   '='   ;



DOT: '.'        ;
    

	
group:
  '('! term ')'!
  | ATOM
  | nil
  | nil2
  | methodExe
;

mult: (( MUL | DIV )^ (group | WORD))? (group | WORD)   ;
add:  (( ADD | SUB )^ mult)? mult     ;
compare:   (( GE | LE | NEQUALS | EQUALS | GT | LT)^ add)? add  ;
term: compare  ;

dotPair : '('! (ATOM | dotPair | NIL) DOT^ (ATOM | dotPair | NIL) ')'!   ;                                   

nil: NIL;
nil2: '()' -> NIL;

list: (QUOTE^ (( '('! (ATOM | WORD)+ ')'! ) | (group | WORD)) );


argumentListLike: list | nil | cdr | cons | nil2      ;
argumentATOMLike: (QUOTE^ (ATOM | WORD)) | car        ;
allArguments: argumentListLike | argumentATOMLike     ;

car:  '('! CAR^ allArguments ')'!      ;
cdr:  '('! CDR^ allArguments ')'!      ;
cons: '('! CONS^ allArguments allArguments ')'! ;
eq:   '('! EQUAL^  (allArguments allArguments) ')'! ;
nuLL: '('! NULL^ allArguments ')'!     ;

assign: WORD ASSIGN^ (group | WORD);

methodSignature: WORD^ '('! WORD* ')'! ;
fun: '('! DEFUN^ methodSignature expr* ')'! ;

methodExe: '('! WORD^ '('! (group | WORD)* ')'! ')'!;

myif: '('! IF^ compare expr expr? ')'! ;

expr:
  group
| dotPair
| '"'! WORD '"'!
| list
| car
| cdr
| cons
| eq
| nil
| nil2
| nuLL
| assign
| fun
| methodExe
| WORD
| myif
;

program: expr* -> ^(BLOCK expr*);

result: program EOF!;

public execute:
  result
;