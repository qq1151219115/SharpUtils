﻿/* Date: 3.9.2017, Time: 4:05 */
using System;
using System.Collections.Generic;
using System.IO;

namespace IllidanS4.SharpUtils.IO.FileSystems
{
	/// <summary>
	/// Represents a file system in the universal file system.
	/// </summary>
	public interface IFileSystem
	{
		FileAttributes GetAttributes(Uri uri);
		DateTime GetCreationTime(Uri uri);
		DateTime GetLastAccessTime(Uri uri);
		DateTime GetLastWriteTime(Uri uri);
		long GetLength(Uri uri);
		Stream GetStream(Uri uri, FileMode mode, FileAccess access);
		Uri GetTarget(Uri uri);
		string GetContentType(Uri uri);
		List<Uri> GetResources(Uri uri);
	}
}
