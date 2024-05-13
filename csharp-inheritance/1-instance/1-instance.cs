using System;
    /// <summary>
    /// Vérifie si l'objet est de type array.
    /// </summary>
class Obj
{
    /// <param name="obj">L'objet à vérifier.</param>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
            /// <returns>Retourne true si l'objet est de type Array, sinon false.</returns>
    }
}
