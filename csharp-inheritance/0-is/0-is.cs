using System;
    class Obj
      /// <summary>
    /// Vérifie si l'objet est de type int.
    /// </summary>
    {
        public static bool IsOfTypeInt(object obj)
            /// <param name="obj">L'objet à vérifier.</param>
        {
            return obj is int;
                /// <returns>Retourne true si l'objet est de type int, sinon false.</returns>
        }
    }
