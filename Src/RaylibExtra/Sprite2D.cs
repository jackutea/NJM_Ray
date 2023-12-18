using System.Numerics;

namespace Raylib_cs.Extra;

public struct Sprite2D {

    public Texture2D tex;
    public Vector2 pos;
    public float rot;
    public float scale;
    public Color tint;

    public void Initialize(string textureFile, Vector2 pos, float rot, float scale, Color tint) {
        tex = Raylib.LoadTexture(textureFile);
        Initialize(tex, pos, rot, scale, tint);
    }

    public void Initialize(Texture2D tex, Vector2 pos, float rot, float scale, Color tint) {
        this.tex = tex;
        this.pos = pos;
        this.rot = rot;
        this.scale = scale;
        this.tint = tint;
    }

    public void Draw() {
        Draw(Vector2.Zero, 0);
    }

    public void Draw(Vector2 parentPos, float parentRot) {
        Raylib.DrawTexturePro(tex,
                              new Rectangle(0, 0, tex.Width / 2, tex.Height / 2),
                              new Rectangle(pos.X + parentPos.X, pos.Y + parentPos.Y, tex.Width * scale, tex.Height * scale),
                              new Vector2(),
                              rot + parentRot,
                              tint);
    }

}