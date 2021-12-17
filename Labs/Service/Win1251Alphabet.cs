using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Labs.Service
{
	public class Win1251Alphabet
	{
		public List<(int id, string letter)> IdLetters { get; set; }

		public Win1251Alphabet()
		{
			IdLetters = new List<(int id, string IdLetters)>()
			{
				(16,"А"), (17,"Б"), (18,"В"), (19,"Г"), (20,"Д"), (21,"Е"), (22,"Ж"),
				(23,"З"), (24,"И"), (25,"Й"), (26,"К"), (27,"Л"), (28,"М"), (29,"Н"),
				(30,"О"), (31,"П"), (32,"Р"), (33,"С"), (34,"Т"), (35,"У"), (36,"Ф"),
				(37,"Х"), (38,"Ц"), (39,"Ч"), (40,"Ш"), (41,"Щ"), (42,"Ъ"), (43,"Ы"),
				(44,"Ь"), (45,"Э"), (46,"Ю"), (47,"Я"), (48,"а"), (49,"б"), (50,"в"),
				(51,"г"), (52,"д"), (53,"е"), (54,"ж"), (55,"з"), (56,"и"), (57,"й"),
				(58,"к"), (59,"л"), (60,"м"), (61,"н"), (62,"о"), (63,"п"), (64,"р"),
				(65,"с"), (66,"т"), (67,"у"), (68,"ф"), (69,"х"), (70,"ц"), (71,"ч"),
				(72,"ш"), (73,"щ"), (74,"ъ"), (75,"ы"), (76,"ь"), (77,"э"), (78,"ю"),
				(79,"я"), 
			};
		}

		public string GetLetter(int id)
		{
			try
			{
				return IdLetters.Single(x => x.id == id)
					.letter;
			}
			catch
			{
				throw new Exception("No such letter by given Id");
			}
		}

		public int GetId(string letter)
		{
			try
			{
				return IdLetters.Single(x => x.letter == letter)
					.id;
			}
			catch
			{
				throw new Exception("No such id by given letter");
			}
		}

		public BigInteger ConvertTextToIdsNumber(string text)
		{
			StringBuilder row = new StringBuilder();
			foreach (var letter in text)
			{
				var id = GetId(letter.ToString());
				row.Append(id);
			}

			return BigInteger.Parse(row.ToString());
		}

		public bool IsValid(string text)
		{
			var letters = IdLetters.Select(x => x.letter).ToList();
			return text.All(x => letters.Contains(x.ToString()));
		}
	}
}
