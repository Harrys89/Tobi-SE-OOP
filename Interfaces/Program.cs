/*
..var orderService = new OrderService();
orderService.ProcessOrder("123456");
*/
using Interfaces;

var ConsoeLogger = new ConsoleLogger();
var orderService = new OrederService(ConsoeLogger);
orderService.ProcessOrder("123456");
orderService.ProcessOrder("127345");

var filelogger = new FileLogger();
var orederServiseWithFileLogger = new OrederService(filelogger);
orederServiseWithFileLogger.ProcessOrder("426340967237");
orederServiseWithFileLogger.ProcessOrder("876342863487634");