using Antlr4.Runtime;
using ParserArithmetic;

string input = "5*6+9*3-1";

Console.WriteLine($"Input: {input}\n");

ICharStream stream = CharStreams.fromString(input);
AritmeticaLexer lexer = new AritmeticaLexer(stream);
CommonTokenStream tokens = new CommonTokenStream(lexer);
AritmeticaParser parser = new AritmeticaParser(tokens);
var tree = parser.aritmetica();
Aritmetica aritmetica = new Aritmetica();
int x = aritmetica.Visit(tree);