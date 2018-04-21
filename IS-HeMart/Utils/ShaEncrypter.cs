﻿using System.Security.Cryptography;
using System.Text;

namespace IS_HeMart.Utils
{
	public static class ShaEncrypter
	{
		public static string Hash(string input)
		{
			using (SHA1Managed sha1 = new SHA1Managed())
			{
				var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
				var sb = new StringBuilder(hash.Length * 2);

				foreach (byte b in hash)
				{
					// can be "x2" if you want lowercase
					sb.Append(b.ToString("x2"));
				}

				return sb.ToString();
			}
		}
	}
}
