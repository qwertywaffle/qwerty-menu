﻿using GorillaNetworking;
using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace flower_mods.Mods
{
    internal class kickall
    {
        static string test;
        public static void KickAll()
        {
            {
                if (PhotonNetwork.InRoom)
                {
                    test = PhotonNetwork.CurrentRoom.Name;
                    PhotonView view = GameObject.Find("WorldShareableCosmetic").GetComponent<WorldShareableItem>().guard.photonView;
                    for (int i = 0; i < 100; i++)
                    {
                        view.RPC("OwnershipRequested", RpcTarget.All, new object[] { "kdwf" });
                    }
                    PhotonNetwork.SendAllOutgoingCommands();
                    PhotonNetwork.NetworkingClient.LoadBalancingPeer.SendOutgoingCommands();
                }
                else
                {
                    if (test != string.Empty)
                    {
                        PhotonNetworkController.Instance.AttemptToJoinSpecificRoom(test, JoinType.Solo);
                        test = string.Empty;
                    }

                }
            }
        }
    }
}