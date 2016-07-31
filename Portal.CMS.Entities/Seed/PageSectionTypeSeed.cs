﻿using Portal.CMS.Entities.Entities.PageBuilder;
using System.Collections.Generic;
using System.Linq;

namespace Portal.CMS.Entities.Seed
{
    public static class PageSectionTypeSeed
    {
        public static void Seed(PortalEntityModel context)
        {
            var sectionList = context.PageSectionTypes.ToList();

            var newSections = new List<PageSectionType>();

            if (!sectionList.Any(x => x.PageSectionTypeName == "Introduction"))
                newSections.Add(new PageSectionType { PageSectionTypeName = "Introduction", PageSectionTypeCategory = PageSectionTypeCategory.Header, PageSectionTypeOrder = 1, PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"header background-parallax height-medium\"><div class=\"overlay-medium\"></div><div id=\"component-<componentStamp>-<sectionId>\" class=\"vertical-alignment component-container\"><h1 id=\"title-<sectionId>\" data-section=\"1\">Custom Page</h1><p id=\"subtitle-<sectionId>\">This is copy that can be updated and changed.</p></div></section>" });

            if (!sectionList.Any(x => x.PageSectionTypeName == "Empty Section"))
                newSections.Add(new PageSectionType { PageSectionTypeName = "Empty Section", PageSectionTypeCategory = PageSectionTypeCategory.Content, PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"blank height-medium background-static\" style=\"background-size: contain;\"></section>" });

            if (!sectionList.Any(x => x.PageSectionTypeName == "Block Text"))
                newSections.Add(new PageSectionType { PageSectionTypeName = "Block Text", PageSectionTypeCategory = PageSectionTypeCategory.Misc, PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"block block-text height-tiny\"><h1 id=\"title-<sectionId>\">Call for a Quote</h1><h1 id=\"subtitle-<sectionId>\">00000 000 000</h1></section>" });

            if (!sectionList.Any(x => x.PageSectionTypeName == "Quote"))
                newSections.Add(new PageSectionType { PageSectionTypeName = "Quote", PageSectionTypeCategory = PageSectionTypeCategory.Misc, PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"quote\"><div class=\"quote-image-left\"></div><div class=\"quote-image-right\"></div><div id=\"container-<componentStamp>-<sectionId>\" class=\"vertical-alignment component-container\"><h1 id=\"quote-<componentStamp>-<sectionId>\">Perfection is not attainable, but if we chase perfection we can catch.</h1><p id=\"component-<componentStamp>-<sectionId>\">Tom McClean</p></div></section>" });

            if (!sectionList.Any(x => x.PageSectionTypeName == "Split Content (Image x2)"))
                newSections.Add(new PageSectionType { PageSectionTypeName = "Split Content (Image x2)", PageSectionTypeCategory = PageSectionTypeCategory.Content, PageSectionTypeOrder = 2, PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"blank height-medium background-static\" style=\"background-size: contain;\"><h1 id=\"title-<componentStamp>-<sectionId>\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem.</h1><p id=\"subtitle-<componentStamp>-<sectionId>\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem. Purto erat facilisis sea id, vulputate deseruisse eos te, errem doctus feugiat te prim.</p><div id=\"component-<componentStamp>-<sectionId>\" class=\"container component-container\"><div id=\"row-<componentStamp>-<sectionId>\" class=\"row component-container\"><div id=\"group-1-<componentStamp>-<sectionId>\" class=\"col-xs-12 col-sm-6 component-container\"><div id=\"image-1-<componentStamp>-<sectionId>\" class=\"image image-standard\"></div><h4 id=\"title-1-<componentStamp>-<sectionId>\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem.</h4><p id=\"subtitle-1-<componentStamp>-<sectionId>\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem. Purto erat facilisis sea id, vulputate deseruisse eos te, errem doctus feugiat te prim.</p><a id=\"button-1-<componentStamp>-<sectionId>\" href=\"#\" class=\"btn\">Click me to find out more.</a></div><div id=\"group-2-<componentStamp>-<sectionId>\" class=\"col-xs-12 col-sm-6 component-container\"><div id=\"image-2-<componentStamp>-<sectionId>\" class=\"image image-standard\"></div><h4 id=\"title-2-<componentStamp>-<sectionId>\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem.</h4><p id=\"subtitle-2-<componentStamp>-<sectionId>\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem. Purto erat facilisis sea id, vulputate deseruisse eos te, errem doctus feugiat te prim.</p><a id=\"button-2-<componentStamp>-<sectionId>\" href=\"#\" class=\"btn\">Click me to find out more.</a></div></div></div></section>" });

            if (!sectionList.Any(x => x.PageSectionTypeName == "Split Content (Icon x6)"))
                newSections.Add(new PageSectionType { PageSectionTypeName = "Split Content (Icon x6)", PageSectionTypeCategory = PageSectionTypeCategory.Content, PageSectionTypeOrder = 3, PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"blank height-medium background-static\" style=\"background-size: contain;\"><h1 id=\"title-<componentStamp>-<sectionId>\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem.</h1><p id=\"subtitle-<componentStamp>-<sectionId>\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem. Purto erat facilisis sea id, vulputate deseruisse eos te, errem doctus feugiat te prim.</p><div id=\"container-<componentStamp>-<sectionId>\" class=\"container component-container\"><div id=\"row-<componentStamp>-<sectionId>\" class=\"row component-container\"><div id=\"item-1-<componentStamp>-<sectionId>\" class=\"col-xs-12 col-sm-6 col-md-4 component-container\"><div id=\"icon-1-<componentStamp>-<sectionId>\" class=\"image image-icon\" style=\"background-image: url('/Areas/Builder/Content/Images/Sample/icon-1.png');\"></div><h4 id=\"subtitle-1-<componentStamp>-<sectionId>\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem.</h4><p id=\"text-1-<componentStamp>-<sectionId>\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem. Purto erat facilisis sea id, vulputate deseruisse eos te, errem doctus feugiat te prim.</p></div><div id=\"item-2-<componentStamp>-<sectionId>\" class=\"col-xs-12 col-sm-6 col-md-4 component-container\"><div id=\"icon-2-<componentStamp>-<sectionId>\" class=\"image image-icon\" style=\"background-image: url('/Areas/Builder/Content/Images/Sample/icon-2.png');\"></div><h4 id=\"subtitle-2-<componentStamp>-<sectionId>\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem.</h4><p id=\"text-2-<componentStamp>-<sectionId>\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem. Purto erat facilisis sea id, vulputate deseruisse eos te, errem doctus feugiat te prim.</p></div><div id=\"item-3-<componentStamp>-<sectionId>\" class=\"col-xs-12 col-sm-6 col-md-4 component-container\"><div id=\"icon-3-<componentStamp>-<sectionId>\" class=\"image image-icon\" style=\"background-image: url('/Areas/Builder/Content/Images/Sample/icon-3.png');\"></div><h4 id=\"subtitle-3-<componentStamp>-<sectionId>\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem.</h4><p id=\"text-3-<componentStamp>-<sectionId>\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem. Purto erat facilisis sea id, vulputate deseruisse eos te, errem doctus feugiat te prim.</p></div><div id=\"item-4-<componentStamp>-<sectionId>\" class=\"col-xs-12 col-sm-6 col-md-4 component-container\"><div id=\"icon-4-<componentStamp>-<sectionId>\" class=\"image image-icon\" style=\"background-image: url('/Areas/Builder/Content/Images/Sample/icon-4.png');\"></div><h4 id=\"subtitle-4-<componentStamp>-<sectionId>\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem.</h4><p id=\"text-4-<componentStamp>-<sectionId>\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem. Purto erat facilisis sea id, vulputate deseruisse eos te, errem doctus feugiat te prim.</p></div><div id=\"item-5-<componentStamp>-<sectionId>\" class=\"col-xs-12 col-sm-6 col-md-4 component-container\"><div id=\"icon-5-<componentStamp>-<sectionId>\" class=\"image image-icon\" style=\"background-image: url('/Areas/Builder/Content/Images/Sample/icon-5.png');\"></div><h4 id=\"subtitle-5-<componentStamp>-<sectionId>\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem.</h4><p id=\"text-5-<componentStamp>-<sectionId>\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem. Purto erat facilisis sea id, vulputate deseruisse eos te, errem doctus feugiat te prim.</p></div><div id=\"item-6-<componentStamp>-<sectionId>\" class=\"col-xs-12 col-sm-6 col-md-4 component-container\"><div id=\"icon-6-<componentStamp>-<sectionId>\" class=\"image image-icon\" style=\"background-image: url('/Areas/Builder/Content/Images/Sample/icon-6.png');\"></div><h4 id=\"subtitle-6-<componentStamp>-<sectionId>\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem.</h4><p id=\"text-6-<componentStamp>-<sectionId>\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem. Purto erat facilisis sea id, vulputate deseruisse eos te, errem doctus feugiat te prim.</p></div></div></div></section>" });

            if (!sectionList.Any(x => x.PageSectionTypeName == "Highlight"))
                newSections.Add(new PageSectionType { PageSectionTypeName = "Highlight", PageSectionTypeCategory = PageSectionTypeCategory.Misc, PageSectionTypeOrder = 4, PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"highlight height-standard background-parallax\" style=\"background-size: cover;\"><div id=\"component-container-<componentStamp>-<sectionId>\" class=\"vertical-alignment component-container\"><h1 id=\"title-<componentStamp>-<sectionId>\" style=\"color: rgb(255, 255, 255);\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem.</h1><p id=\"text-1-<componentStamp>-<sectionId>\" style=\"color: rgb(255, 255, 255);\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem. Purto erat facilisis sea id, vulputate deseruisse eos te, errem doctus feugiat te prim.</p><p id=\"text-2-<componentStamp>-<sectionId>\" style=\"color: rgb(255, 255, 255);\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem. Purto erat facilisis sea id, vulputate deseruisse eos te, errem doctus feugiat te prim.</p></div><div id=\"overlay-<componentStamp>-<sectionId>\" class=\"overlay overlay-medium\"></div></section>" });

            if (!sectionList.Any(x => x.PageSectionTypeName == "Data Table"))
                newSections.Add(new PageSectionType { PageSectionTypeName = "Data Table", PageSectionTypeCategory = PageSectionTypeCategory.Content, PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"blank height-medium background-static\" style=\"background-size: contain;\"><h1 id=\"title-<componentStamp>-<sectionId>\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem.</h1><p id=\"subtitle-<componentStamp>-<sectionId>\">Lorem ipsum dolor sit amet, eu qui accusam scriptorem. Purto erat facilisis sea id, vulputate deseruisse eos te, errem doctus feugiat te prim.</p><table id=\"table-<componentStamp>-<sectionId>\" class=\"component-container\"><tr id=\"row-1-<componentStamp>-<sectionId>\" class=\"component-container\"><th id=\"header-1-1-<componentStamp>-<sectionId>\" class=\"component-container\"><p id=\"label-1-1-<componentStamp>-<sectionId>\">Header 1</p></th><th id=\"header-1-2-<componentStamp>-<sectionId>\" class=\"component-container\"><p id=\"label-1-2-<componentStamp>-<sectionId>\">Header 2</p></th><th id=\"header-1-3-<componentStamp>-<sectionId>\" class=\"component-container\"><p id=\"label-1-3-<componentStamp>-<sectionId>\">Header 3</p></th><th id=\"header-1-4-<componentStamp>-<sectionId>\" class=\"component-container\"><p id=\"label-1-4-<componentStamp>-<sectionId>\">Header 4</p></th></tr><tr id=\"row-2-<componentStamp>-<sectionId>\" class=\"component-container\"><td id=\"header-2-1-<componentStamp>-<sectionId>\" class=\"component-container\"><p id=\"label-2-1-<componentStamp>-<sectionId>\">Data Point 1</p></td><td id=\"header-2-2-<componentStamp>-<sectionId>\" class=\"component-container\"><p id=\"label-2-2-<componentStamp>-<sectionId>\">Data Point 2</p></td><td id=\"header-2-3-<componentStamp>-<sectionId>\" class=\"component-container\"><p id=\"label-2-3-<componentStamp>-<sectionId>\">Data Point 3</p></td><td id=\"header-2-4-<componentStamp>-<sectionId>\" class=\"component-container\"><p id=\"label-2-4-<componentStamp>-<sectionId>\">Data Point 4</p></td></tr><tr id=\"row-3-<componentStamp>-<sectionId>\" class=\"component-container\"><td id=\"header-3-1-<componentStamp>-<sectionId>\" class=\"component-container\"><p id=\"label-3-1-<componentStamp>-<sectionId>\">Data Point 1</p></td><td id=\"header-3-2-<componentStamp>-<sectionId>\" class=\"component-container\"><p id=\"label-3-2-<componentStamp>-<sectionId>\">Data Point 2</p></td><td id=\"header-3-3-<componentStamp>-<sectionId>\" class=\"component-container\"><p id=\"label-3-3-<componentStamp>-<sectionId>\">Data Point 3</p></td><td id=\"header-3-4-<componentStamp>-<sectionId>\" class=\"component-container\"><p id=\"label-3-4-<componentStamp>-<sectionId>\">Data Point 4</p></td></tr><tr id=\"row-4-<componentStamp>-<sectionId>\" class=\"component-container\"><td id=\"header-4-1-<componentStamp>-<sectionId>\" class=\"component-container\"><p id=\"label-4-1-<componentStamp>-<sectionId>\">Data Point 1</p></td><td id=\"header-4-2-<componentStamp>-<sectionId>\" class=\"component-container\"><p id=\"label-4-2-<componentStamp>-<sectionId>\">Data Point 2</p></td><td id=\"header-4-3-<componentStamp>-<sectionId>\" class=\"component-container\"><p id=\"label-4-3-<componentStamp>-<sectionId>\">Data Point 3</p></td><td id=\"header-4-4-<componentStamp>-<sectionId>\" class=\"component-container\"><p id=\"label-4-4-<componentStamp>-<sectionId>\">Data Point 4</p></td></tr></table></section>" });

            if (!sectionList.Any(x => x.PageSectionTypeName == "Image & Text"))
                newSections.Add(new PageSectionType { PageSectionTypeName = "Image & Text", PageSectionTypeCategory = PageSectionTypeCategory.Content, PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"blank height-small background-static\" style=\"background-size: contain;\"><table id=\"table-<componentStamp>-<sectionId>\" class=\"component-container\"><tr id=\"row-<componentStamp>-<sectionId>\" class=\"component-container\"><td id=\"column-1-<componentStamp>-<sectionId>\" class=\"component-container hidden-xs hidden-sm\"><img id=\"image-<componentStamp>-<sectionId>\" class=\"image image-auto\" src=\"/Areas/Builder/Content/Images/Sample/small-sample-1.jpg\"></td><td id=\"column-2-<componentStamp>-<sectionId>\" class=\"component-container\"><h1 id=\"title-<componentStamp>-<sectionId>\">LOREM IPSUM DOLOR SIT AMET.</h1><p id=\"text-<componentStamp>-<sectionId>\"><span style=\"line-height: 28.5714px;\">Lorem ipsum dolor sit amet, cu ignota singulis senserit mei, at mea delenit nonumes luptatum. Ea sea eligendi copiosae, at ius senserit rationibus scriptorem. Sint appareat has et, te mel debet populo admodum. Quo cu utroque accusam, mei duis temporibus no.&nbsp;</span><span style=\"line-height: 28.5714px;\">Ea sea eligendi copiosae, at ius senserit rationibus scriptorem.&nbsp;</span><span style=\"line-height: 28.5714px;\">Ea sea eligendi copiosae, at ius senserit rationibus scriptorem. Sint appareat has et, te mel debet populo admodum.</span><span style=\"line-height: 28.5714px;\">&nbsp;Sint appareat has et, te mel debet populo&nbsp;admodum.</span></p></td></tr></table></section>" });

            if (!sectionList.Any(x => x.PageSectionTypeName == "Text & Image"))
                newSections.Add(new PageSectionType { PageSectionTypeName = "Text & Image", PageSectionTypeCategory = PageSectionTypeCategory.Content, PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"blank height-small background-static\" style=\"background-size: contain;\"><table id=\"table-<componentStamp>-<sectionId>\" class=\"component-container\"><tr id=\"row-<componentStamp>-<sectionId>\" class=\"component-container\"><td id=\"column-2-<componentStamp>-<sectionId>\" class=\"component-container\"><h1 id=\"title-<componentStamp>-<sectionId>\">LOREM IPSUM DOLOR SIT AMET.</h1><p id=\"text-<componentStamp>-<sectionId>\"><span style=\"line-height: 28.5714px;\">Lorem ipsum dolor sit amet, cu ignota singulis senserit mei, at mea delenit nonumes luptatum. Ea sea eligendi copiosae, at ius senserit rationibus scriptorem. Sint appareat has et, te mel debet populo admodum. Quo cu utroque accusam, mei duis temporibus no.&nbsp;</span><span style=\"line-height: 28.5714px;\">Ea sea eligendi copiosae, at ius senserit rationibus scriptorem.&nbsp;</span><span style=\"line-height: 28.5714px;\">Ea sea eligendi copiosae, at ius senserit rationibus scriptorem. Sint appareat has et, te mel debet populo admodum.</span><span style=\"line-height: 28.5714px;\">&nbsp;Sint appareat has et, te mel debet populo&nbsp;admodum.</span></p></td><td id=\"column-1-<componentStamp>-<sectionId>\" class=\"component-container hidden-xs hidden-sm\"><img id=\"image-<componentStamp>-<sectionId>\" class=\"image image-auto\" src=\"/Areas/Builder/Content/Images/Sample/small-sample-1.jpg\"></td></tr></table></section>" });

            if (!sectionList.Any(x => x.PageSectionTypeName == "Contact Form"))
                newSections.Add(new PageSectionType { PageSectionTypeName = "Contact Form", PageSectionTypeCategory = PageSectionTypeCategory.Misc, PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"contact background-parallax height-medium\"><div class=\"overlay overlay-dark\"></div><div class=\"inner\"><div id=\"container-<componentStamp>-<sectionId>\" class=\"container component-container\"><form action=\"/Build/Contact\" method=\"post\"><h1 id=\"title-<componentStamp>-<sectionId>\">Send an Email</h1><p id=\"text-<componentStamp>-<sectionId>\">We love receiving feedback, both positive and constructive. Please send us your thoughts using the form below, we generally respond within 24 hours.</p><input id=\"pageSectionId\" name=\"pageSectionId\" style=\"display: none;\" value=\"<sectionId>\"><div class=\"row\"><div class=\"col-xs-12 col-sm-6\"><input id=\"yourName\" placeholder=\"Name (Required)\" name=\"yourName\"><input id=\"yourEmail\" placeholder=\"Email Address (Required)\" name=\"yourEmail\"><input id=\"yourSubject\" placeholder=\"Subject\" name=\"yourSubject\"></div><div class=\"col-xs-12 col-sm-6\"><textarea id=\"yourMessage\" placeholder=\"Message (Required)\" name=\"yourMessage\"></textarea></div><div class=\"col-xs-12\"><button>Send Message</button></div></div></form></div></div></section>" });

            if (!sectionList.Any(x => x.PageSectionTypeName == "Photo Gallery"))
                newSections.Add(new PageSectionType { PageSectionTypeName = "Photo Gallery", PageSectionTypeCategory = PageSectionTypeCategory.Misc, PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"gallery height-standard background-parallax\"><div id=\"image-1-<componentStamp>-<sectionId>\" class=\"image\" style=\"background-image: url('/Areas/Builder/Content/Images/Sample/Sample-1.jpg');\"></div><div id=\"image-2-<componentStamp>-<sectionId>\" class=\"image\" style=\"background-image: url('/Areas/Builder/Content/Images/Sample/Sample-2.jpg');\"></div><div id=\"image-3-<componentStamp>-<sectionId>\" class=\"image\" style=\"background-image: url('/Areas/Builder/Content/Images/Sample/Sample-3.jpg');\"></div><div id=\"image-4-<componentStamp>-<sectionId>\" class=\"image\" style=\"background-image: url('/Areas/Builder/Content/Images/Sample/Sample-4.jpg');\"></div></section>" });

            if (!sectionList.Any(x => x.PageSectionTypeName == "Recent Posts"))
                newSections.Add(new PageSectionType { PageSectionTypeName = "Recent Posts", PageSectionTypeCategory = PageSectionTypeCategory.Content, PageSectionTypeBody = "<section id=\"section-<sectionId>\" class=\"blank height-small background-static\" style=\"background-size: contain;\"><h1 id=\"component-<componentStamp>-<sectionId>\">Recent Posts</h1><p id=\"component-<componentStamp>-<sectionId>\">Here are the most recent posts on our blog.</p><div id=\"widget-<componentStamp>-<sectionId>\" class=\"widget-wrapper post-list-wrapper\" style=\"text-align: left;\"><div class=\"vertical-alignment\"><div class=\"loading-wrapper\" style=\"text-align: center;\"><div style=\"background-color: black; padding: 10px; display: inline-block;\"><img src=\"/Areas/Builder/Content/Images/Sample/loading-graphic.gif\"></div></div></div></div></section>" });

            if (newSections.Any())
                context.PageSectionTypes.AddRange(newSections);
        }
    }
}