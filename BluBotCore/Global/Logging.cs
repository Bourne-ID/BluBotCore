using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

public class ApplicationLogging
{
	private static ILoggerFactory _Factory = null;

	public static ILoggerFactory LoggerFactory
	{
		get
		{
			if (_Factory == null)
			{
				_Factory = new LoggerFactory();
				_Factory.AddProvider(new ConsoleLoggerProvider((s, level) => true, false));

			}
			return _Factory;
		}
		set { _Factory = value; }
	}
}