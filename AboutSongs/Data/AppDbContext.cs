using AboutSongs.Models;
using AboutSongs.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace AboutSongs.Data;

public class AppDbContext : IdentityDbContext<IdentityUser>
{

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Album> Albuns { get; set; }
    public DbSet<AlbumArtista> AlbumArtistas { get; set; }
    public DbSet<AlbumGenero> AlbumGeneros { get; set; }
    public DbSet<Artista> Artistas { get; set; }
    public DbSet<ComentarioAlbum> ComentarioAlbuns { get; set; }
    public DbSet<ComentarioMusica> ComentarioMusicas { get; set; }
    public DbSet<Critica> Criticas { get; set; }
    public DbSet<Genero> Generos { get; set; }
    public DbSet<GeneroArtista> GeneroArtistas { get; set; }
    public DbSet<Musica> Musicas { get; set; }
    public DbSet<MusicaGenero> MusicaGeneros { get; set; }
    public DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        AppDbSeed seed = new(builder);

        #region Relacionamento de Muitos para Muitos - Album Artista
        builder.Entity<AlbumArtista>()
            .HasKey(aa => new { aa.AlbumId, aa.ArtistaId, aa.MusicaId });
        #endregion

        #region Relacionamento de Muitos para Muitos - Album Genero
        builder.Entity<AlbumGenero>()
            .HasKey(ag => new { ag.AlbumId, ag.GeneroId });
        #endregion

        #region Relacionamento de Muitos para Muitos - GeneroArtista

        builder.Entity<GeneroArtista>()
            .HasKey(ga => new { ga.GeneroId, ga.ArtistaId });
        #endregion

        #region Relacionamento de Muitos para Muitos - MusicaGenero

        builder.Entity<MusicaGenero>()
            .HasKey(mg => new { mg.MusicaId, mg.GeneroId });
        #endregion
    }
}