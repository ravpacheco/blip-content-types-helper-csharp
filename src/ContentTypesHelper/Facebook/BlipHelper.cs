using Lime.Messaging.Contents;
using Lime.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take.Blip.ContentTypesHelper.Facebook
{
    public static class BlipHelper
    {
        public static PlainText CreateText(string text)
        {
            return new PlainText
            {
                Text = text
            };
        }

        public static MediaLink CreateImage(string imageUrl,
            string type = "image/*",
            string previewUrl = null,
            string previewType = "image/*",
            string title = null,
            string text = null,
            string aspectRation = null)
        {
            if (imageUrl == null) throw new ArgumentNullException(nameof(imageUrl));

            return CreateImage(new Uri(Uri.EscapeUriString(imageUrl)),
                type,
                previewUrl.IsNullOrEmpty() ? null : new Uri(Uri.EscapeUriString(previewUrl)),
                previewType,
                title,
                text,
                aspectRation);
        }

        public static MediaLink CreateImage(Uri imageUrl,
            string type = "image/*",
            Uri previewUrl = null,
            string previewType = "image/*",
            string title = null,
            string text = null,
            string aspectRation = null)
        {
            if (imageUrl == null) throw new ArgumentNullException(nameof(imageUrl));

            return new MediaLink
            {
                Title = title,
                Text = text,
                AspectRatio = aspectRation,
                PreviewUri = previewUrl,
                PreviewType = MediaType.Parse(previewType),
                Uri = imageUrl,
                Type = MediaType.Parse(type),
            };
        }

        public static MediaLink CreateSquareImage(string imageUrl,
            string type = "image/*",
            string previewUrl = null,
            string previewType = "image/*",
            string title = null,
            string text = null)
        {
            return CreateImage(imageUrl, type, previewUrl, previewType, title, text, "1:1");
        }

        public static MediaLink CreateSquareImage(Uri imageUrl,
            string type = "image/*",
            Uri previewUrl = null,
            string previewType = "image/*",
            string title = null,
            string text = null)
        {
            return CreateImage(imageUrl, type, previewUrl, previewType, title, text, "1:1");
        }
    }
}
