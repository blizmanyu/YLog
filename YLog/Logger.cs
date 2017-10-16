using System;
using System.Text;

namespace YLog
{
	public class Logger
	{
		#region Fields
		public enum LogLevel { Trace, Debug, Info, Warn, Error, Fatal }

		// PIVs //
		private DateTime startTime, endTime;
		private LogLevel logLevel;
		private StringBuilder log;
		private int traceCount, debugCount, infoCount, warnCount, errorCount, fatalCount;
		#endregion

		#region Public Methods
		public Logger()
		{
			startTime = DateTime.Now;
			logLevel = LogLevel.Trace;
			log = new StringBuilder();
			traceCount = 0;
			debugCount = 0;
			infoCount = 0;
			warnCount = 0;
			errorCount = 0;
			fatalCount = 0;
		}

		#region Trace Overloads
		public void Trace(string message)
		{
			traceCount++;
			log.Append(String.Format("[{0}|Trace] {1}", DateTime.Now.ToLongDateString(), message));
		}

		public void Trace(string message, object arg0)
		{
			traceCount++;
			log.Append(String.Format("[{0}|Trace] {1}", DateTime.Now.ToLongDateString(), String.Format(message, arg0)));
		}

		public void Trace(string message, object arg0, object arg1)
		{
			traceCount++;
			log.Append(String.Format("[{0}|Trace] {1}", DateTime.Now.ToLongDateString(), String.Format(message, arg0, arg1)));
		}

		public void Trace(string message, object arg0, object arg1, object arg2)
		{
			traceCount++;
			log.Append(String.Format("[{0}|Trace] {1}", DateTime.Now.ToLongDateString(), String.Format(message, arg0, arg1, arg2)));
		}

		public void Trace(string message, object[] args)
		{
			traceCount++;
			log.Append(String.Format("[{0}|Trace] {1}", DateTime.Now.ToLongDateString(), String.Format(message, args)));
		}
		#endregion

		#region Debug Overloads
		public void Debug(string message)
		{
			debugCount++;
			log.Append(String.Format("[{0}|Debug] {1}", DateTime.Now.ToLongDateString(), message));
		}

		public void Debug(string message, object arg0)
		{
			debugCount++;
			log.Append(String.Format("[{0}|Debug] {1}", DateTime.Now.ToLongDateString(), String.Format(message, arg0)));
		}

		public void Debug(string message, object arg0, object arg1)
		{
			debugCount++;
			log.Append(String.Format("[{0}|Debug] {1}", DateTime.Now.ToLongDateString(), String.Format(message, arg0, arg1)));
		}

		public void Debug(string message, object arg0, object arg1, object arg2)
		{
			debugCount++;
			log.Append(String.Format("[{0}|Debug] {1}", DateTime.Now.ToLongDateString(), String.Format(message, arg0, arg1, arg2)));
		}

		public void Debug(string message, object[] args)
		{
			debugCount++;
			log.Append(String.Format("[{0}|Debug] {1}", DateTime.Now.ToLongDateString(), String.Format(message, args)));
		}
		#endregion

		#region Info Overloads
		public void Info(string message)
		{
			infoCount++;
			log.Append(String.Format("[{0}|Info] {1}", DateTime.Now.ToLongDateString(), message));
		}

		public void Info(string message, object arg0)
		{
			infoCount++;
			log.Append(String.Format("[{0}|Info] {1}", DateTime.Now.ToLongDateString(), String.Format(message, arg0)));
		}

		public void Info(string message, object arg0, object arg1)
		{
			infoCount++;
			log.Append(String.Format("[{0}|Info] {1}", DateTime.Now.ToLongDateString(), String.Format(message, arg0, arg1)));
		}

		public void Info(string message, object arg0, object arg1, object arg2)
		{
			infoCount++;
			log.Append(String.Format("[{0}|Info] {1}", DateTime.Now.ToLongDateString(), String.Format(message, arg0, arg1, arg2)));
		}

		public void Info(string message, object[] args)
		{
			infoCount++;
			log.Append(String.Format("[{0}|Info] {1}", DateTime.Now.ToLongDateString(), String.Format(message, args)));
		}
		#endregion

		#region Warn Overloads
		public void Warn(string message)
		{
			warnCount++;
			log.Append(String.Format("[{0}|Warn] {1}", DateTime.Now.ToLongDateString(), message));
		}

		public void Warn(string message, object arg0)
		{
			warnCount++;
			log.Append(String.Format("[{0}|Warn] {1}", DateTime.Now.ToLongDateString(), String.Format(message, arg0)));
		}

		public void Warn(string message, object arg0, object arg1)
		{
			warnCount++;
			log.Append(String.Format("[{0}|Warn] {1}", DateTime.Now.ToLongDateString(), String.Format(message, arg0, arg1)));
		}

		public void Warn(string message, object arg0, object arg1, object arg2)
		{
			warnCount++;
			log.Append(String.Format("[{0}|Warn] {1}", DateTime.Now.ToLongDateString(), String.Format(message, arg0, arg1, arg2)));
		}

		public void Warn(string message, object[] args)
		{
			warnCount++;
			log.Append(String.Format("[{0}|Warn] {1}", DateTime.Now.ToLongDateString(), String.Format(message, args)));
		}
		#endregion

		#region Error Overloads
		public void Error(string message)
		{
			errorCount++;
			log.Append(String.Format("[{0}|Error] {1}", DateTime.Now.ToLongDateString(), message));
		}

		public void Error(string message, object arg0)
		{
			errorCount++;
			log.Append(String.Format("[{0}|Error] {1}", DateTime.Now.ToLongDateString(), String.Format(message, arg0)));
		}

		public void Error(string message, object arg0, object arg1)
		{
			errorCount++;
			log.Append(String.Format("[{0}|Error] {1}", DateTime.Now.ToLongDateString(), String.Format(message, arg0, arg1)));
		}

		public void Error(string message, object arg0, object arg1, object arg2)
		{
			errorCount++;
			log.Append(String.Format("[{0}|Error] {1}", DateTime.Now.ToLongDateString(), String.Format(message, arg0, arg1, arg2)));
		}

		public void Error(string message, object[] args)
		{
			errorCount++;
			log.Append(String.Format("[{0}|Error] {1}", DateTime.Now.ToLongDateString(), String.Format(message, args)));
		}
		#endregion

		#region Fatal Overloads
		public void Fatal(string message)
		{
			fatalCount++;
			log.Append(String.Format("[{0}|Fatal] {1}", DateTime.Now.ToLongDateString(), message));
		}

		public void Fatal(string message, object arg0)
		{
			fatalCount++;
			log.Append(String.Format("[{0}|Fatal] {1}", DateTime.Now.ToLongDateString(), String.Format(message, arg0)));
		}

		public void Fatal(string message, object arg0, object arg1)
		{
			fatalCount++;
			log.Append(String.Format("[{0}|Fatal] {1}", DateTime.Now.ToLongDateString(), String.Format(message, arg0, arg1)));
		}

		public void Fatal(string message, object arg0, object arg1, object arg2)
		{
			fatalCount++;
			log.Append(String.Format("[{0}|Fatal] {1}", DateTime.Now.ToLongDateString(), String.Format(message, arg0, arg1, arg2)));
		}

		public void Fatal(string message, object[] args)
		{
			fatalCount++;
			log.Append(String.Format("[{0}|Fatal] {1}", DateTime.Now.ToLongDateString(), String.Format(message, args)));
		}
		#endregion

		#region Log Overloads
		public void Log(LogLevel logLevel, string message)
		{
			IncrementCount(logLevel);
			log.Append(String.Format("[{0}|{1}] {2}", DateTime.Now.ToLongDateString(), logLevel, message));
		}

		public void Log(LogLevel logLevel, string message, object arg0)
		{
			IncrementCount(logLevel);
			log.Append(String.Format("[{0}|{1}] {2}", DateTime.Now.ToLongDateString(), logLevel, String.Format(message, arg0)));
		}

		public void Log(LogLevel logLevel, string message, object arg0, object arg1)
		{
			IncrementCount(logLevel);
			log.Append(String.Format("[{0}|{1}] {2}", DateTime.Now.ToLongDateString(), logLevel, String.Format(message, arg0, arg1)));
		}

		public void Log(LogLevel logLevel, string message, object arg0, object arg1, object arg2)
		{
			IncrementCount(logLevel);
			log.Append(String.Format("[{0}|{1}] {2}", DateTime.Now.ToLongDateString(), logLevel, String.Format(message, arg0, arg1, arg2)));
		}

		public void Log(LogLevel logLevel, string message, object[] args)
		{
			IncrementCount(logLevel);
			log.Append(String.Format("[{0}|{1}] {2}", DateTime.Now.ToLongDateString(), logLevel, String.Format(message, args)));
		}
		#endregion
		#endregion

		#region Private Helpers
		private void IncrementCount(LogLevel logLevel)
		{
			switch (logLevel) {
				case LogLevel.Trace:
					traceCount++;
					break;
				case LogLevel.Debug:
					debugCount++;
					break;
				case LogLevel.Info:
					infoCount++;
					break;
				case LogLevel.Warn:
					warnCount++;
					break;
				case LogLevel.Error:
					errorCount++;
					break;
				case LogLevel.Fatal:
					fatalCount++;
					break;
				default:
					break;
			}
		}
		#endregion
	}
}