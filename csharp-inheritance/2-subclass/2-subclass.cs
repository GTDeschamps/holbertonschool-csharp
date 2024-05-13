using System;
    /// <summary>
    /// Vérifie si l'objet appartien à une subclass.
    /// </summary>
class Obj
{
    /// <param name="obj">L'objet à vérifier.</param>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return baseType.IsAssignableFrom(derivedType) && derivedType != baseType;
    }
}
