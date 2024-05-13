using System;
    /// <summary>
    /// Vérifie si l'objet est de type int.
    /// </summary>
class Obj
{
    /// <param name="obj">L'objet à vérifier.</param>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
            /// <returns>Retourne true si l'objet est de type int, sinon false.</returns>
    }
}
