using PiTung;
using PiTung.Components;
using System;
using UnityEngine;
namespace CBT_Demo
{
	public class CBT_Demo : Mod
	{
		public override string Name => "Custom Prefab Utilites For PiTUNG Demo";
		public override string PackageName => "Ryan.CPUFP Demo";
		public override string Author => "Ryan";
		public override Version ModVersion => new Version("1.0.0");
		public override void BeforePatch()
		{
			var Test = PrefabBuilder.Custom(() => CBT.createCube(1, 1))
				.WithInput(new Vector3(0, 0.15f, 0.15f), Quaternion.Euler(90,0,0));
			ComponentRegistry.CreateNew<Empty>("Custom Builder Test", "Test", Test);
			var Test2 = PrefabBuilder.Custom(() => CBT.createCube(1, 1))
				.WithInput(CBT.getPegPos(1,1, "F"),  CBT.getPegQuat(1, 1, "F"),"Front")
				.WithInput(CBT.getPegPos(1, 1, "B"), CBT.getPegQuat(1, 1, "B"), "Back")
				.WithInput(CBT.getPegPos(1, 1, "L"), CBT.getPegQuat(1, 1, "L"), "Left")
				.WithInput(CBT.getPegPos(1, 1, "R"), CBT.getPegQuat(1, 1, "R"), "Right")
				.WithInput(CBT.getPegPos(1, 1, "T"), CBT.getPegQuat(1, 1, "T"), "Top");
			ComponentRegistry.CreateNew<Empty>("Custom Builder Test2", "Test2", Test2);
			var SizeX = 2;
			var SizeY = 2;
			var Test22 = PrefabBuilder.Custom(() => CBT.createCube(2, 2))
				.WithInput(CBT.getPegPos(SizeX, SizeY, "F"), CBT.getPegQuat(SizeX, SizeY, "F"), "Front")
				.WithInput(CBT.getPegPos(SizeX, SizeY, "B"), CBT.getPegQuat(SizeX, SizeY, "B"), "Back")
				.WithInput(CBT.getPegPos(SizeX, SizeY, "L"), CBT.getPegQuat(SizeX, SizeY, "L"), "Left")
				.WithInput(CBT.getPegPos(SizeX, SizeY, "R"), CBT.getPegQuat(SizeX, SizeY, "R"), "Right")
				.WithInput(CBT.getPegPos(SizeX, SizeY, "T"), CBT.getPegQuat(SizeX, SizeY, "T"), "Top");
			ComponentRegistry.CreateNew<Empty>("Custom Builder Test2x2", "Test2x2", Test22);

			SizeX = 3;
			SizeY = 3;
			var Test33 = PrefabBuilder.Custom(() => CBT.createCube(3, 3))
				.WithInput(CBT.getPegPos(SizeX, SizeY, "F"), CBT.getPegQuat(SizeX, SizeY, "F"), "Front")
				.WithInput(CBT.getPegPos(SizeX, SizeY, "B"), CBT.getPegQuat(SizeX, SizeY, "B"), "Back")
				.WithInput(CBT.getPegPos(SizeX, SizeY, "L"), CBT.getPegQuat(SizeX, SizeY, "L"), "Left")
				.WithInput(CBT.getPegPos(SizeX, SizeY, "R"), CBT.getPegQuat(SizeX, SizeY, "R"), "Right")
				.WithInput(CBT.getPegPos(SizeX, SizeY, "T"), CBT.getPegQuat(SizeX, SizeY, "T"), "Top");
			ComponentRegistry.CreateNew<Empty>("Custom Builder Test3x3", "Test3x3", Test33);

			SizeX = 2;
			SizeY = 3;
			var Test23 = PrefabBuilder.Custom(() => CBT.createCube(2, 3))
				.WithInput(CBT.getPegPos(SizeX, SizeY, "F"), CBT.getPegQuat(SizeX, SizeY, "F"), "Front")
				.WithInput(CBT.getPegPos(SizeX, SizeY, "B"), CBT.getPegQuat(SizeX, SizeY, "B"), "Back")
				.WithInput(CBT.getPegPos(SizeX, SizeY, "L"), CBT.getPegQuat(SizeX, SizeY, "L"), "Left")
				.WithInput(CBT.getPegPos(SizeX, SizeY, "R"), CBT.getPegQuat(SizeX, SizeY, "R"), "Right")
				.WithInput(CBT.getPegPos(SizeX, SizeY, "T"), CBT.getPegQuat(SizeX, SizeY, "T"), "Top");
			ComponentRegistry.CreateNew<Empty>("Custom Builder Test2x3", "Test2x3", Test23);
			SizeX = 3;
			SizeY = 2;
			var Test32 = PrefabBuilder.Custom(() => CBT.createCube(3, 2))
				.WithInput(CBT.getPegPos(SizeX, SizeY, "F"), CBT.getPegQuat(SizeX, SizeY, "F"), "Front")
				.WithInput(CBT.getPegPos(SizeX, SizeY, "B"), CBT.getPegQuat(SizeX, SizeY, "B"), "Back")
				.WithInput(CBT.getPegPos(SizeX, SizeY, "L"), CBT.getPegQuat(SizeX, SizeY, "L"), "Left")
				.WithInput(CBT.getPegPos(SizeX, SizeY, "R"), CBT.getPegQuat(SizeX, SizeY, "R"), "Right")
				.WithInput(CBT.getPegPos(SizeX, SizeY, "T"), CBT.getPegQuat(SizeX, SizeY, "T"), "Top");
			ComponentRegistry.CreateNew<Empty>("Custom Builder Test3x2", "Test3x2", Test32);

			SizeX = 3;
			SizeY = 3;
			var TestO = PrefabBuilder.Custom(() => CBT.createCube(3, 3))
				.WithOutput(CBT.getPegPos(SizeX, SizeY, "F"), CBT.getPegQuat(SizeX, SizeY, "F"), "Front")
				.WithOutput(CBT.getPegPos(SizeX, SizeY, "B"), CBT.getPegQuat(SizeX, SizeY, "B"), "Back")
				.WithOutput(CBT.getPegPos(SizeX, SizeY, "L"), CBT.getPegQuat(SizeX, SizeY, "L"), "Left")
				.WithOutput(CBT.getPegPos(SizeX, SizeY, "R"), CBT.getPegQuat(SizeX, SizeY, "R"), "Right")
				.WithOutput(CBT.getPegPos(SizeX, SizeY, "T"), CBT.getPegQuat(SizeX, SizeY, "T"), "Top");
			ComponentRegistry.CreateNew<Empty>("Custom Builder TestO", "Test With Outputs", TestO);

			SizeX = 3;
			SizeY = 3;
			var Test3D = PrefabBuilder.Custom(() => CBT.createCube(3, 3, 3))
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "F"), CBT.getPegQuat(SizeX, SizeY, 3, "F"), "Front")
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "B"), CBT.getPegQuat(SizeX, SizeY, 3, "B"), "Back")
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "L"), CBT.getPegQuat(SizeX, SizeY, 3, "L"), "Left")
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "R"), CBT.getPegQuat(SizeX, SizeY, 3, "R"), "Right")
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "T"), CBT.getPegQuat(SizeX, SizeY, 3, "T"), "Top");
			ComponentRegistry.CreateNew<Empty>("Custom Builder Test3D", "Vertial Test 3 High", Test3D);

			SizeX = 3;
			SizeY = 2;
			var Test332 = PrefabBuilder.Custom(() => CBT.createCube(3, 2, 3))
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "F"), CBT.getPegQuat(SizeX, SizeY, 3, "F"), "Front")
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "B"), CBT.getPegQuat(SizeX, SizeY, 3, "B"), "Back")
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "L"), CBT.getPegQuat(SizeX, SizeY, 3, "L"), "Left")
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "R"), CBT.getPegQuat(SizeX, SizeY, 3, "R"), "Right")
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "T"), CBT.getPegQuat(SizeX, SizeY, 3, "T"), "Top");
			ComponentRegistry.CreateNew<Empty>("Custom Builder Test3D x 2", "Vertial Test 2 High", Test332);

			SizeX = 3;
			SizeY = 3;
			var Testos = PrefabBuilder.Custom(() => CBT.createCube(3, 3))
				.WithInput(CBT.getPegPos(SizeX, SizeY, "F"), CBT.getPegQuat(SizeX, SizeY, "F"), "Front")
				.WithInput(CBT.getPegPos(SizeX, SizeY, "F", 1, 0), CBT.getPegQuat(SizeX, SizeY, "F"), "Front Left Side")
				.WithInput(CBT.getPegPos(SizeX, SizeY, "F", -1, 0), CBT.getPegQuat(SizeX, SizeY, "F"), "Front Right Side")
				.WithInput(CBT.getPegPos(SizeX, SizeY, "B"), CBT.getPegQuat(SizeX, SizeY, "B"), "Back")
				.WithInput(CBT.getPegPos(SizeX, SizeY, "B", 1, 0), CBT.getPegQuat(SizeX, SizeY, "B"), "Back Left Side")
				.WithInput(CBT.getPegPos(SizeX, SizeY, "B", -1, 0), CBT.getPegQuat(SizeX, SizeY, "B"), "Back Right Side")
				.WithInput(CBT.getPegPos(SizeX, SizeY, "L"), CBT.getPegQuat(SizeX, SizeY, "L"), "Left")
				.WithInput(CBT.getPegPos(SizeX, SizeY, "L", 1, 0), CBT.getPegQuat(SizeX, SizeY, "L"), "Left Left Side")
				.WithInput(CBT.getPegPos(SizeX, SizeY, "L", -1, 0), CBT.getPegQuat(SizeX, SizeY, "L"), "Left Right Side")
				.WithInput(CBT.getPegPos(SizeX, SizeY, "R"), CBT.getPegQuat(SizeX, SizeY, "R"), "Right")
				.WithInput(CBT.getPegPos(SizeX, SizeY, "R", 1, 0), CBT.getPegQuat(SizeX, SizeY, "R"), "Right Left Side")
				.WithInput(CBT.getPegPos(SizeX, SizeY, "R", -1, 0), CBT.getPegQuat(SizeX, SizeY, "R"), "Right Right Side")
				.WithInput(CBT.getPegPos(SizeX, SizeY, "T"), CBT.getPegQuat(SizeX, SizeY, "T"), "Top")
				.WithInput(CBT.getPegPos(SizeX, SizeY, "T", 1, 0), CBT.getPegQuat(SizeX, SizeY, "T"), "Top Left Side")
				.WithInput(CBT.getPegPos(SizeX, SizeY, "T", -1, 0), CBT.getPegQuat(SizeX, SizeY, "T"), "Top Right Side")
				.WithInput(CBT.getPegPos(SizeX, SizeY,  "T", 0, 1), CBT.getPegQuat(SizeX, SizeY,  "T"), "Top Front Side")
				.WithInput(CBT.getPegPos(SizeX, SizeY,  "T", 0, -1), CBT.getPegQuat(SizeX, SizeY, "T"), "Top Back Side");
			ComponentRegistry.CreateNew<Empty>("Custom Builder TestOS", "Offset Test", Testos);

			SizeX = 3;
			SizeY = 3;
			var Testos3D = PrefabBuilder.Custom(() => CBT.createCube(3, 3, 3))
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "F"), CBT.getPegQuat(SizeX, SizeY, 3, "F"), "Front")
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "F", 1, 0), CBT.getPegQuat(SizeX, SizeY, 3, "F"), "Front Left Side")
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "F", -1, 0), CBT.getPegQuat(SizeX, SizeY, 3, "F"), "Front Right Side")
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "F", 0, 1), CBT.getPegQuat(SizeX, SizeY, 3, "F"), "Front Top Side")
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "F", 0, -1), CBT.getPegQuat(SizeX, SizeY, 3, "F"), "Front Bottom Side")
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "B"), CBT.getPegQuat(SizeX, SizeY, 3, "B"), "Back")
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "B", 1, 0), CBT.getPegQuat(SizeX, SizeY, 3, "B"), "Back Left Side")
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "B", -1, 0), CBT.getPegQuat(SizeX, SizeY, 3, "B"), "Back Right Side")
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "B", 0, 1), CBT.getPegQuat(SizeX, SizeY, 3, "B"), "Back Top Side")
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "B", 0, -1), CBT.getPegQuat(SizeX, SizeY, 3, "B"), "Back Bottom Side")
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "L"), CBT.getPegQuat(SizeX, SizeY, 3, "L"), "Left")
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "L", 1, 0), CBT.getPegQuat(SizeX, SizeY, 3, "L"), "Left Left Side")
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "L", -1, 0), CBT.getPegQuat(SizeX, SizeY, 3, "L"), "Left Right Side")
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "L", 0, 1), CBT.getPegQuat(SizeX, SizeY, 3, "L"), "Left Top Side")
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "L", 0, -1), CBT.getPegQuat(SizeX, SizeY, 3, "L"), "Left Bottom Side")
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "R"), CBT.getPegQuat(SizeX, SizeY, 3, "R"), "Right")
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "R", 1, 0), CBT.getPegQuat(SizeX, SizeY, 3, "R"), "Right Left Side")
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "R", -1, 0), CBT.getPegQuat(SizeX, SizeY, 3, "R"), "Right Right Side")
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "R", 0, 1), CBT.getPegQuat(SizeX, SizeY, 3, "R"), "Right Top Side")
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "R", 0, -1), CBT.getPegQuat(SizeX, SizeY, 3, "R"), "Rigt Bottom Side")
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "T"), CBT.getPegQuat(SizeX, SizeY, 3, "T"), "Top")
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "T", 1, 0), CBT.getPegQuat(SizeX, SizeY, 3, "T"), "Top Left Side")
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "T", -1, 0), CBT.getPegQuat(SizeX, SizeY, 3, "T"), "Top Right Side")
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "T", 0, 1), CBT.getPegQuat(SizeX, SizeY, 3, "T"), "Top Front Side")
				.WithInput(CBT.getPegPos(SizeX, SizeY, 3, "T", 0, -1), CBT.getPegQuat(SizeX, SizeY, 3, "T"), "Top Back Side");
			ComponentRegistry.CreateNew<Empty>("Custom Builder TestOS3D", " Vertical Offset Test", Testos3D);
		}
	}
}
