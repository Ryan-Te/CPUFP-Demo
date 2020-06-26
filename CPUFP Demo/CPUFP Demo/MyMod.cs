using PiTung;
using PiTung.Components;
using System;
using UnityEngine;
namespace CPUFP_Demo
{
	public class CPUFP_Demo : Mod
	{
		public override string Name => "Custom Prefab Utilites For PiTUNG Demo";
		public override string PackageName => "Ryan.CPUFP Demo";
		public override string Author => "Ryan";
		public override Version ModVersion => new Version("1.0.0");
		public override void BeforePatch()
		{
			var Test = PrefabBuilder.Custom(() => CPUFP.createCube(1, 1))
				.WithInput(new Vector3(0, 0.15f, 0.15f), Quaternion.Euler(90,0,0));
			ComponentRegistry.CreateNew<Empty>("Custom Builder Test", "Test", Test);
			var Test2 = PrefabBuilder.Custom(() => CPUFP.createCube(1, 1))
				.WithInput(CPUFP.getPegPos(1,1, "F"),  CPUFP.getPegQuat(1, 1, "F"),"Front")
				.WithInput(CPUFP.getPegPos(1, 1, "B"), CPUFP.getPegQuat(1, 1, "B"), "Back")
				.WithInput(CPUFP.getPegPos(1, 1, "L"), CPUFP.getPegQuat(1, 1, "L"), "Left")
				.WithInput(CPUFP.getPegPos(1, 1, "R"), CPUFP.getPegQuat(1, 1, "R"), "Right")
				.WithInput(CPUFP.getPegPos(1, 1, "T"), CPUFP.getPegQuat(1, 1, "T"), "Top");
			ComponentRegistry.CreateNew<Empty>("Custom Builder Test2", "Test2", Test2);
			var SizeX = 2;
			var SizeY = 2;
			var Test22 = PrefabBuilder.Custom(() => CPUFP.createCube(2, 2))
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "F"), CPUFP.getPegQuat(SizeX, SizeY, "F"), "Front")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "B"), CPUFP.getPegQuat(SizeX, SizeY, "B"), "Back")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "L"), CPUFP.getPegQuat(SizeX, SizeY, "L"), "Left")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "R"), CPUFP.getPegQuat(SizeX, SizeY, "R"), "Right")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "T"), CPUFP.getPegQuat(SizeX, SizeY, "T"), "Top");
			ComponentRegistry.CreateNew<Empty>("Custom Builder Test2x2", "Test2x2", Test22);

			SizeX = 3;
			SizeY = 3;
			var Test33 = PrefabBuilder.Custom(() => CPUFP.createCube(3, 3))
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "F"), CPUFP.getPegQuat(SizeX, SizeY, "F"), "Front")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "B"), CPUFP.getPegQuat(SizeX, SizeY, "B"), "Back")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "L"), CPUFP.getPegQuat(SizeX, SizeY, "L"), "Left")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "R"), CPUFP.getPegQuat(SizeX, SizeY, "R"), "Right")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "T"), CPUFP.getPegQuat(SizeX, SizeY, "T"), "Top");
			ComponentRegistry.CreateNew<Empty>("Custom Builder Test3x3", "Test3x3", Test33);

			SizeX = 2;
			SizeY = 3;
			var Test23 = PrefabBuilder.Custom(() => CPUFP.createCube(2, 3))
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "F"), CPUFP.getPegQuat(SizeX, SizeY, "F"), "Front")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "B"), CPUFP.getPegQuat(SizeX, SizeY, "B"), "Back")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "L"), CPUFP.getPegQuat(SizeX, SizeY, "L"), "Left")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "R"), CPUFP.getPegQuat(SizeX, SizeY, "R"), "Right")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "T"), CPUFP.getPegQuat(SizeX, SizeY, "T"), "Top");
			ComponentRegistry.CreateNew<Empty>("Custom Builder Test2x3", "Test2x3", Test23);
			SizeX = 3;
			SizeY = 2;
			var Test32 = PrefabBuilder.Custom(() => CPUFP.createCube(3, 2))
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "F"), CPUFP.getPegQuat(SizeX, SizeY, "F"), "Front")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "B"), CPUFP.getPegQuat(SizeX, SizeY, "B"), "Back")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "L"), CPUFP.getPegQuat(SizeX, SizeY, "L"), "Left")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "R"), CPUFP.getPegQuat(SizeX, SizeY, "R"), "Right")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "T"), CPUFP.getPegQuat(SizeX, SizeY, "T"), "Top");
			ComponentRegistry.CreateNew<Empty>("Custom Builder Test3x2", "Test3x2", Test32);

			SizeX = 3;
			SizeY = 3;
			var TestO = PrefabBuilder.Custom(() => CPUFP.createCube(3, 3))
				.WithOutput(CPUFP.getPegPos(SizeX, SizeY, "F"), CPUFP.getPegQuat(SizeX, SizeY, "F"), "Front")
				.WithOutput(CPUFP.getPegPos(SizeX, SizeY, "B"), CPUFP.getPegQuat(SizeX, SizeY, "B"), "Back")
				.WithOutput(CPUFP.getPegPos(SizeX, SizeY, "L"), CPUFP.getPegQuat(SizeX, SizeY, "L"), "Left")
				.WithOutput(CPUFP.getPegPos(SizeX, SizeY, "R"), CPUFP.getPegQuat(SizeX, SizeY, "R"), "Right")
				.WithOutput(CPUFP.getPegPos(SizeX, SizeY, "T"), CPUFP.getPegQuat(SizeX, SizeY, "T"), "Top");
			ComponentRegistry.CreateNew<Empty>("Custom Builder TestO", "Test With Outputs", TestO);

			SizeX = 3;
			SizeY = 3;
			var Test3D = PrefabBuilder.Custom(() => CPUFP.createCube(3, 3, 3))
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "F"), CPUFP.getPegQuat(SizeX, SizeY, 3, "F"), "Front")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "B"), CPUFP.getPegQuat(SizeX, SizeY, 3, "B"), "Back")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "L"), CPUFP.getPegQuat(SizeX, SizeY, 3, "L"), "Left")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "R"), CPUFP.getPegQuat(SizeX, SizeY, 3, "R"), "Right")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "T"), CPUFP.getPegQuat(SizeX, SizeY, 3, "T"), "Top");
			ComponentRegistry.CreateNew<Empty>("Custom Builder Test3D", "Vertial Test 3 High", Test3D);

			SizeX = 3;
			SizeY = 2;
			var Test332 = PrefabBuilder.Custom(() => CPUFP.createCube(3, 2, 3))
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "F"), CPUFP.getPegQuat(SizeX, SizeY, 3, "F"), "Front")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "B"), CPUFP.getPegQuat(SizeX, SizeY, 3, "B"), "Back")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "L"), CPUFP.getPegQuat(SizeX, SizeY, 3, "L"), "Left")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "R"), CPUFP.getPegQuat(SizeX, SizeY, 3, "R"), "Right")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "T"), CPUFP.getPegQuat(SizeX, SizeY, 3, "T"), "Top");
			ComponentRegistry.CreateNew<Empty>("Custom Builder Test3D x 2", "Vertial Test 2 High", Test332);

			SizeX = 3;
			SizeY = 3;
			var Testos = PrefabBuilder.Custom(() => CPUFP.createCube(3, 3))
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "F"), CPUFP.getPegQuat(SizeX, SizeY, "F"), "Front")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "F", 1, 0), CPUFP.getPegQuat(SizeX, SizeY, "F"), "Front Left Side")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "F", -1, 0), CPUFP.getPegQuat(SizeX, SizeY, "F"), "Front Right Side")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "B"), CPUFP.getPegQuat(SizeX, SizeY, "B"), "Back")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "B", 1, 0), CPUFP.getPegQuat(SizeX, SizeY, "B"), "Back Left Side")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "B", -1, 0), CPUFP.getPegQuat(SizeX, SizeY, "B"), "Back Right Side")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "L"), CPUFP.getPegQuat(SizeX, SizeY, "L"), "Left")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "L", 1, 0), CPUFP.getPegQuat(SizeX, SizeY, "L"), "Left Left Side")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "L", -1, 0), CPUFP.getPegQuat(SizeX, SizeY, "L"), "Left Right Side")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "R"), CPUFP.getPegQuat(SizeX, SizeY, "R"), "Right")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "R", 1, 0), CPUFP.getPegQuat(SizeX, SizeY, "R"), "Right Left Side")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "R", -1, 0), CPUFP.getPegQuat(SizeX, SizeY, "R"), "Right Right Side")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "T"), CPUFP.getPegQuat(SizeX, SizeY, "T"), "Top")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "T", 1, 0), CPUFP.getPegQuat(SizeX, SizeY, "T"), "Top Left Side")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, "T", -1, 0), CPUFP.getPegQuat(SizeX, SizeY, "T"), "Top Right Side")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY,  "T", 0, 1), CPUFP.getPegQuat(SizeX, SizeY,  "T"), "Top Front Side")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY,  "T", 0, -1), CPUFP.getPegQuat(SizeX, SizeY, "T"), "Top Back Side");
			ComponentRegistry.CreateNew<Empty>("Custom Builder TestOS", "Offset Test", Testos);

			SizeX = 3;
			SizeY = 3;
			var Testos3D = PrefabBuilder.Custom(() => CPUFP.createCube(3, 3, 3))
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "F"), CPUFP.getPegQuat(SizeX, SizeY, 3, "F"), "Front")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "F", 1, 0), CPUFP.getPegQuat(SizeX, SizeY, 3, "F"), "Front Left Side")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "F", -1, 0), CPUFP.getPegQuat(SizeX, SizeY, 3, "F"), "Front Right Side")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "F", 0, 1), CPUFP.getPegQuat(SizeX, SizeY, 3, "F"), "Front Top Side")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "F", 0, -1), CPUFP.getPegQuat(SizeX, SizeY, 3, "F"), "Front Bottom Side")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "B"), CPUFP.getPegQuat(SizeX, SizeY, 3, "B"), "Back")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "B", 1, 0), CPUFP.getPegQuat(SizeX, SizeY, 3, "B"), "Back Left Side")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "B", -1, 0), CPUFP.getPegQuat(SizeX, SizeY, 3, "B"), "Back Right Side")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "B", 0, 1), CPUFP.getPegQuat(SizeX, SizeY, 3, "B"), "Back Top Side")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "B", 0, -1), CPUFP.getPegQuat(SizeX, SizeY, 3, "B"), "Back Bottom Side")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "L"), CPUFP.getPegQuat(SizeX, SizeY, 3, "L"), "Left")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "L", 1, 0), CPUFP.getPegQuat(SizeX, SizeY, 3, "L"), "Left Left Side")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "L", -1, 0), CPUFP.getPegQuat(SizeX, SizeY, 3, "L"), "Left Right Side")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "L", 0, 1), CPUFP.getPegQuat(SizeX, SizeY, 3, "L"), "Left Top Side")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "L", 0, -1), CPUFP.getPegQuat(SizeX, SizeY, 3, "L"), "Left Bottom Side")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "R"), CPUFP.getPegQuat(SizeX, SizeY, 3, "R"), "Right")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "R", 1, 0), CPUFP.getPegQuat(SizeX, SizeY, 3, "R"), "Right Left Side")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "R", -1, 0), CPUFP.getPegQuat(SizeX, SizeY, 3, "R"), "Right Right Side")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "R", 0, 1), CPUFP.getPegQuat(SizeX, SizeY, 3, "R"), "Right Top Side")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "R", 0, -1), CPUFP.getPegQuat(SizeX, SizeY, 3, "R"), "Rigt Bottom Side")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "T"), CPUFP.getPegQuat(SizeX, SizeY, 3, "T"), "Top")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "T", 1, 0), CPUFP.getPegQuat(SizeX, SizeY, 3, "T"), "Top Left Side")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "T", -1, 0), CPUFP.getPegQuat(SizeX, SizeY, 3, "T"), "Top Right Side")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "T", 0, 1), CPUFP.getPegQuat(SizeX, SizeY, 3, "T"), "Top Front Side")
				.WithInput(CPUFP.getPegPos(SizeX, SizeY, 3, "T", 0, -1), CPUFP.getPegQuat(SizeX, SizeY, 3, "T"), "Top Back Side");
			ComponentRegistry.CreateNew<Empty>("Custom Builder TestOS3D", " Vertical Offset Test", Testos3D);
		}
	}
}
