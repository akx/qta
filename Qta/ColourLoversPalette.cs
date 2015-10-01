/*
 * Date: 21.12.2009
 * Time: 21:28
 */
using System;
using System.Drawing;
using System.Collections.Generic;
using System.Xml.XPath;
using System.Globalization;

namespace Qta
{
	/// <summary>
	/// Description of ColourLoversPalette.
	/// </summary>
	public class ColourLoversPalette
	{
		List<Color> colors;
		int id;
		string title;
		string userName;
		int numViews;
		int numVotes;
		int numComments;
		double numHearts;
		int rank;
		DateTime dateCreated;
		string description;
		string url;
		string imageUrl;
		string badgeUrl;
		string apiUrl;
		
		public Color[] Colors {
			get { return colors.ToArray(); }
		}
	
		public int Id {
			get { return id; }
		}
		
		public string Title {
			get { return title; }
		}
		
		public string UserName {
			get { return userName; }
		}
		
		public int NumViews {
			get { return numViews; }
		}
		
		public int NumVotes {
			get { return numVotes; }
		}
		
		public int NumComments {
			get { return numComments; }
		}
		
		public double NumHearts {
			get { return numHearts; }
		}
		
		public int Rank {
			get { return rank; }
		}
		
		public DateTime DateCreated {
			get { return dateCreated; }
		}
		
		public string Description {
			get { return description; }
		}
		
		public string Url {
			get { return url; }
		}
		
		public string ImageUrl {
			get { return imageUrl; }
		}
		
		public string BadgeUrl {
			get { return badgeUrl; }
		}
		
		public string ApiUrl {
			get { return apiUrl; }
		}
		
		
		public ColourLoversPalette()
		{
			colors = new List<Color>(5);
		}
		
		private static string getXPathExprContent(XPathNavigator node, string expr, string defaultValue)
		{
			XPathNodeIterator xpni = node.Select(expr);
			if(xpni.Count == 0) return defaultValue;
			xpni.MoveNext();
			return xpni.Current.Value;
		}
		
		public void PopulateFromXPathNode(XPathNavigator node)
		{
			//System.Diagnostics.Debug.Print("X = {0}", node.OuterXml);
			id = Convert.ToInt32(getXPathExprContent(node, "./id", "0"));
			title = getXPathExprContent(node, "./title", "(unknown title)");
			userName = getXPathExprContent(node, "./userName", "(unknown user)");
			numViews = Convert.ToInt32(getXPathExprContent(node, "./numViews", "-1"));
			numVotes = Convert.ToInt32(getXPathExprContent(node, "./numVotes", "-1"));
			numComments = Convert.ToInt32(getXPathExprContent(node, "./numComments", "-1"));
			numHearts = Double.Parse(getXPathExprContent(node, "./numHearts", "-1"), new CultureInfo("en-US", false));
			rank = Convert.ToInt32(getXPathExprContent(node, "./rank", "-1"));
			dateCreated = DateTime.Parse(getXPathExprContent(node, "./dateCreated", "1970-01-01 00:00:00"));
			description = getXPathExprContent(node, "./description", "");
			url = getXPathExprContent(node, "./url", "");
			imageUrl = getXPathExprContent(node, "./imageUrl", "");
			badgeUrl = getXPathExprContent(node, "./badgeUrl", "");
			apiUrl = getXPathExprContent(node, "./apiUrl", "");
			XPathNodeIterator colorNodes = node.Select("./colors/hex");
			while(colorNodes.MoveNext()) colors.Add(ColorTranslator.FromHtml("#"+colorNodes.Current.Value));
			colors.TrimExcess();
		}
		
		public string GetColorDescStr()
		{
			string colorsDesc = "";
			foreach(Color c in colors) colorsDesc += ColorTranslator.ToHtml(c) + " ";
			return colorsDesc.TrimEnd();
		}
		
		public override string ToString()
		{
			return string.Format("[#{1}/{2} by {3} - {4}: ({0})]", GetColorDescStr(), this.id, this.title, this.userName, this.url);
		}
		
		public string GetHeartsStr()
		{
			if(numHearts<0) return "?";
			string heartsStr = "";
			int entireHearts = (int)Math.Floor(numHearts);
			bool hasHalfHeart = ((numHearts - entireHearts) > 0);
			while(entireHearts-- > 0) heartsStr += "\u2665";
			if(hasHalfHeart) heartsStr += "\u00BD";
			return heartsStr;
		}
		
	}
}
